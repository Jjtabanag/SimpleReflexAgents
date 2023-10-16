using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace SimpleReflexAgents
{
    public partial class Form1 : Form
    {
        // Mouse Actions
        private bool isDragging = false;
        private Point offset;
        PictureBox[] start_points;

        // Images
        Bitmap room;
        Point roomCoord;
        Bitmap roomba;

        // Shapes
        Rectangle roombaFrame;

        // Room States
        string[] r;
        Dictionary<string, PictureBox> rooms;
        Dictionary<string, string> roomStatus;
        Dictionary<string, bool> visitedRooms;
        Dictionary<string, string> rules;

        // Roomba States
        string currentLocation;
        string nextLocation;
        string currentlyFacing;
        string currentAction;
        bool dirtIsPlaced;

        // Miscellaneous
        Brush brush;

        public Form1()
        {
            InitializeComponent();
            this.Width = 1080;
            this.Height = 800;
            this.KeyPreview = true;
            start_points = new PictureBox[] { startPoint1, startPoint2, startPoint3, startPoint4 };
            room = new Bitmap(Image.FromFile("room.png"), 730, 730);
            roomCoord = new Point((this.Width / 2) - (room.Width / 2), 0);
            roomba = (Bitmap)pbRoomba.Image;
            roombaFrame = new Rectangle(room.Width + roomCoord.X, 0,
                                        roomCoord.X - 15, 300);
            pbRoomba.Image = roomba;
            currentlyFacing = "UP";
            dirtIsPlaced = false;
            //isRotating = false;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(room, roomCoord.X, roomCoord.Y);
            g.FillRectangle(brush = new SolidBrush(Color.FromArgb(255, 226, 191)), roombaFrame);
        }

        private void initRooms()
        {
            r = new string[4] { "A", "B",
                                "C", "D" };

            // Initialize room locations on the form
            rooms = new Dictionary<string, PictureBox> {
                { "A", startPoint1 },
                { "B", startPoint2 },
                { "C", startPoint3 },
                { "D", startPoint4 }
            };

            // Initialize room status (clean or dirty)
            roomStatus = new Dictionary<string, string>
            {
                { "A", "Clean" },
                { "B", "Clean" },
                { "C", "Clean" },
                { "D", "Clean" }
            };

            // Randomly set some rooms as dirty
            if (dirtIsPlaced)
            {
                Random random = new Random();
                int dirtyRoomCount = random.Next(0, 5);
                for (int i = 0; i < dirtyRoomCount; i++)
                {
                    string randomRoom = r[random.Next(r.Length)];
                    roomStatus[randomRoom] = "Dirty";
                }
            }
            

            // Initialize visited rooms
            visitedRooms = new Dictionary<string, bool>
            {
                { "A", false },
                { "B", false },
                { "C", false },
                { "D", false }
            };

            // Initialize the rules
            rules = new Dictionary<string, string>
            {
                { "Dirty", "SUCK" },
                { "A", "DOWN RIGHT" },
                { "B", "DOWN LEFT" },
                { "C", "UP RIGHT" },
                { "D", "UP LEFT" }
            };
        }

        private void btnPlaceDirt_Click(object sender, EventArgs e)
        {
            dirtIsPlaced = true;
            initRooms();
            DirtVisibility(false);
            foreach (string s in r)
            {
                rooms[s].Visible = true;
                rooms[s].BackColor = Color.Transparent;
                if (roomStatus[s] == "Dirty")
                {
                    rooms[s].Image = Image.FromFile("dirt.png");
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!dirtIsPlaced)
                initRooms();

            btnStart.Enabled = false;
            btnPlaceDirt.Enabled = false;
            pbRoomba.Enabled = false;
            RoombaTimer.Interval = 10;
            RoombaTimer.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the form's state to initial values
            initRooms();
            DirtVisibility(false);

            // Reset Roomba position
            pbRoomba.Location = new Point(956, 183);
            currentLocation = "";
            nextLocation = "";
            lblCurrentLocation.Text = "X- Y-";
            lblCurrentRoom.Text = "Origin";
            lblNextRoom.Text = "Origin";

            // Clear Roomba log
            RoombaLog.Clear();

            // Enable UI elements
            btnStart.Enabled = true;
            btnPlaceDirt.Enabled = true;
            pbRoomba.Enabled = true;

            // Refresh the form
            Invalidate();
        }

        private void AppendTextAndWait(string text)
        {
            RoombaLog.Invoke(new Action(() =>
            {
                RoombaLog.AppendText(text + Environment.NewLine);
            }));
            System.Threading.Thread.Sleep(2000); // Sleep for 2 seconds
        }


        private async Task HandleRoombaMovementAsync()
        {
            if (ArrivedAtNextLocation())
            {
                AppendTextAndWait("-> Arrived at next room");
                lblCurrentRoom.Text = nextLocation;
                AppendTextAndWait("-> Perceiving current room...");
                string percept = Perceive();
                string action = SimpleReflexAgent(percept);
                await DoAction(action);
            }
            else
            {
                MoveToNextLocation();
            }

            if (currentAction != "SUCK" && VisitedAllRooms())
            {
                btnStart.Enabled = true;
                btnPlaceDirt.Enabled = true;
                pbRoomba.Enabled = true;
                btnReset.Enabled = true;
                RoombaTimer.Stop();
                MessageBox.Show("Roomba has visited all rooms!");
            }
            Invalidate();
        }

        private async void RoombaTimer_Tick(object sender, EventArgs e)
        {
            await HandleRoombaMovementAsync();
        }

        private string Perceive()
        {
            return currentLocation;
        }

        private string SimpleReflexAgent(string percept)
        {
            string state = InterpretInput(percept);
            string rule = RuleMatch(state, rules);
            string action = RuleAction(rule);
            return action;
        }

        private string InterpretInput(string percept)
        {
            string state;

            if (roomStatus[currentLocation] == "Dirty")
            {
                state = "Dirty";
                RoombaLog.AppendText("-> Room is Dirty" + Environment.NewLine);
            }
            else
            {
                state = currentLocation;
                RoombaLog.AppendText("-> Room is Clean" + Environment.NewLine);
            }

            return state;
        }

        private string RuleMatch(string state, Dictionary<string, string> rules)
        {
            string rule = rules[state];
            return rule;
        }

        private string RuleAction(string rule)
        {
            string action = rule;
            if (action != "SUCK")
            {
                // Split available actions into individual actions
                string[] actions = rule.Split(' ');

                // Select a random available action
                Random random = new Random();
                int randomIndex = random.Next(actions.Length);
                action = actions[randomIndex];

                // If random action goes to visited state, change action
                int index = randomIndex;
                if (IsNextRoomVisited(action))
                {
                    if (randomIndex == 1)
                        index = 0;
                    else
                        index = 1;
                }
                else if (VisitedAllRooms())
                {
                    return "Done";
                }
                action = actions[index];
            }

            currentAction = action;
            return action;
        }

        private async Task DoAction(string action)
        {
            if (VisitedAllRooms() && action != "SUCK")
            {
                RoombaLog.AppendText("-> DONE CLEANING");
                return;
            }

            // Do the action
            if (action == "SUCK")
            {
                AppendTextAndWait("-> Sucking dirt" + Environment.NewLine);
                System.Threading.Thread.Sleep(5000);
                roomStatus[currentLocation] = "Clean";
                rooms[currentLocation].Image = null;
            }
            else
            {
                switch (action)
                {
                    case "UP":
                        if (currentLocation == "C")
                        {
                            if (currentlyFacing != "UP")
                                rotateRoomba(90);
                            nextLocation = "A";
                        }
                        else if (currentLocation == "D")
                        {
                            if (currentlyFacing != "UP")
                                rotateRoomba(-90);
                            nextLocation = "B";
                        }
                        break;

                    case "DOWN":
                        if (currentLocation == "A")
                        {
                            rotateRoomba(180);
                            nextLocation = "C";
                        }
                        else if (currentLocation == "B")
                        {
                            rotateRoomba(180);
                            nextLocation = "D";
                        }
                        break;

                    case "LEFT":
                        if (currentLocation == "B")
                        {
                            rotateRoomba(-90);
                            nextLocation = "A";
                        }
                        else if (currentLocation == "D")
                        {
                            rotateRoomba(-90);
                            nextLocation = "C";
                        }
                        break;

                    case "RIGHT":
                        if (currentLocation == "A")
                        {
                            rotateRoomba(90);
                            nextLocation = "B";
                        }
                        else if (currentLocation == "C")
                        {
                            rotateRoomba(90);
                            nextLocation = "D";
                        }
                        break;
                }
                RoombaLog.AppendText("-> Moving " + action + Environment.NewLine + Environment.NewLine);
            }
            lblNextRoom.Text = nextLocation;
        }

        private bool ArrivedAtNextLocation()
        {
            if (pbRoomba.Location == rooms[nextLocation].Location)
            {
                currentLocation = nextLocation;
                visitedRooms[currentLocation] = true;
                return true;
            }
            return false;
        }

        private void MoveToNextLocation()
        {
            // Calculate new position based on the action
            int newX = pbRoomba.Location.X;
            int newY = pbRoomba.Location.Y;

            switch (currentAction)
            {
                case "UP":
                    newY -= 1; // Move up
                    break;
                case "DOWN":
                    newY += 1; // Move down
                    break;
                case "LEFT":
                    newX -= 1; // Move left
                    break;
                case "RIGHT":
                    newX += 1; // Move right
                    break;
                case "SUCK":
                    break;     // No Moving
            }

            // Update the PictureBox location
            if (currentAction != "SUCK")
                pbRoomba.Location = new Point(newX, newY);

            lblCurrentLocation.Text = "X: " + pbRoomba.Location.X + " Y: " + pbRoomba.Location.Y;
        }

        private void rotateRoomba(float angle)
        {
            //using (Image image = pbRoomba.Image)
            //{
            //    if (angle == 90)
            //        image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //    else if (angle == -90)
            //        image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //    else if (angle == 180)
            //        image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            //    pbRoomba.Image = image;
            //}
        }

        private bool VisitedAllRooms()
        {
            foreach (var roomVisited in visitedRooms.Values)
            {
                if (!roomVisited)
                {
                    return false; // If any room is not visited, return false
                }
            }
            return true; // All rooms have been visited
        }

        private bool IsNextRoomVisited(string action)
        {
            //Checks if the next room is already visited, 
            // if true, then change the first chosen action to the second action
            if (currentLocation == "A")
            {
                if (action == "RIGHT")
                    return visitedRooms["B"];
                else if (action == "DOWN")
                    return visitedRooms["C"];
            }
            else if (currentLocation == "B")
            {
                if (action == "LEFT")
                    return visitedRooms["A"];
                else if (action == "DOWN")
                {
                    return visitedRooms["D"];
                }
            }
            else if (currentLocation == "C")
            {
                if (action == "RIGHT")
                    return visitedRooms["D"];
                else if (action == "UP")
                    return visitedRooms["A"];
            }
            else if (currentLocation == "D")
            {
                if (action == "LEFT")
                    return visitedRooms["C"];
                else if (action == "UP")
                    return visitedRooms["B"];
            }
            return false;
        }


        private void RoombaMouseDown(object sender, MouseEventArgs e)
        {
            DropHereVisibility(true);
            isDragging = true;
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            offset = new Point(e.X, e.Y);
        }

        private void RoombaMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = (PictureBox)sender;
                if (pictureBox != null)
                {
                    Point newLocation = pictureBox.Location;
                    newLocation.X += e.X - offset.X;
                    newLocation.Y += e.Y - offset.Y;
                    pictureBox.Location = newLocation;
                }

                Label[] labels = { lblDH1, lblDH2, lblDH3, lblDH4 };
                Point[] startPoints = { startPoint1.Location, startPoint2.Location, startPoint3.Location, startPoint4.Location };

                Rectangle pictureBoxBounds = new Rectangle(pbRoomba.Location, pbRoomba.Size);

                for (int i = 0; i < labels.Length; i++)
                {
                    Rectangle labelBounds = new Rectangle(labels[i].Location, labels[i].Size);

                    // If any part of the picturebox intersects with any part of the label, picturebox.Location goes to the 
                    // given startpoint locations
                    if (pictureBoxBounds.IntersectsWith(labelBounds))
                    {
                        pbRoomba.Location = startPoints[i];

                        // If any of the startpoint is intersected, the label will be invisible
                        if (startPoints[i] == startPoint1.Location)
                        {
                            lblDH1.Visible = false;
                        }
                        if (startPoints[i] == startPoint2.Location)
                        {
                            lblDH2.Visible = false;
                        }
                        if (startPoints[i] == startPoint3.Location)
                        {
                            lblDH3.Visible = false;
                        }
                        if (startPoints[i] == startPoint4.Location)
                        {
                            lblDH4.Visible = false;
                        }
                        break;
                    }
                    else
                    {
                        DropHereVisibility(true);
                    }
                }
                lblCurrentLocation.Text = "X: " + pbRoomba.Location.X + " Y: " + pbRoomba.Location.Y;
            }
        }

        private void RoombaMouseUp(object sender, MouseEventArgs e)
        {
            DropHereVisibility(false);
            isDragging = false;
            bool correctLocation = false;

            // Roomba is located at any of the start points,
            foreach (Point sp in new Point[] { startPoint1.Location, startPoint2.Location,
                                               startPoint3.Location, startPoint4.Location })
            {
                if (pbRoomba.Location == sp)
                {
                    correctLocation = true;
                    if (sp == startPoint1.Location)
                    {
                        currentLocation = "A";
                    }
                    else if (sp == startPoint2.Location)
                    {
                        currentLocation = "B";
                    }
                    else if (sp == startPoint3.Location)
                    {
                        currentLocation = "C";
                    }
                    else if (sp == startPoint4.Location)
                    {
                        currentLocation = "D";
                    }
                    break;
                }
            }

            nextLocation = currentLocation;

            // Else go back to original location
            if (!correctLocation)
            {
                pbRoomba.Location = new Point(956, 183);
                pbRoomba.BringToFront();
                lblCurrentLocation.Text = "X: " + pbRoomba.Location.X + " Y: " + pbRoomba.Location.Y;
            }
        }

        private void RoombaMouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Cursor = Cursors.Hand;
        }

        private void DropHereVisibility(bool b)
        {
            // Drop here labels are visible or invisible
            Label[] lbl = new Label[4] { lblDH1, lblDH2, lblDH3, lblDH4 };
            foreach (Label l in lbl)
            {
                l.BringToFront();
                l.Visible = b;
            }
        }
        private void DirtVisibility(bool b)
        {
            startPoint1.Visible = b;
            startPoint2.Visible = b;
            startPoint3.Visible = b;
            startPoint4.Visible = b;

            if (!b)
            {
                startPoint1.Image = null;
                startPoint2.Image = null;
                startPoint3.Image = null;
                startPoint4.Image = null;
            }
        }
    }
}