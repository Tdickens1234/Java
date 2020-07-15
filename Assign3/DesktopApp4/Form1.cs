using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Tim Dickens
//Daniel Whalen
//.Net Programming
//z1804759
//z1816950

namespace DesktopApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDicts();
            LoadClassBox();
            LoadServerBoxes();
            LoadRoleBox();
            LoadTypeBox();
            LoadNumericBoxes();
        }

        private void LoadNumericBoxes()
        {
            MinNumeric.Value = 1;
            MinNumeric.Minimum = 1;
            MinNumeric.Maximum = MAX_LEVEL;

            MaxNumeric.Value = 1;
            MaxNumeric.Minimum = 1;
            MaxNumeric.Maximum = MAX_LEVEL;

        }

        private void MinNumeric_ValueChanged(object sender, EventArgs e)
            {
                if (MinNumeric.Value > MaxNumeric.Value)
                {
                    MaxNumeric.Value = MaxNumeric.Value + 1;
                }
            }

        private void MaxNumeric_ValueChanged(object sender, EventArgs e)
            {
                if (MaxNumeric.Value < MinNumeric.Value)
                {
                    MinNumeric.Value = MinNumeric.Value - 1;
                }
            }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MinNumeric_ValueChanged(sender, e);
        }

        private void LoadTypeBox()
        {
            Type tempType = new Type { };
            for(int i = 0; i < 5; i++)
            {
                tempType = (Type)i;
                TypeComboGuild.Items.Add(tempType);
            }
            TypeComboGuild.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadRoleBox()
        {
            Role tempRole = new Role { };
            for(int i = 0; i < 3; i++)
            {
                tempRole = (Role)i;
                RoleComboRole.Items.Add(tempRole);
            }
            RoleComboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadServerBoxes()
        {
            ServerComboClass.Items.Add("Beta4Azeroth");
            ServerComboClass.Items.Add("TKWasASetback");
            ServerComboClass.Items.Add("ZappyBoi");
            ServerComboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            ServerComboRole.Items.Add("Beta4Azeroth");
            ServerComboRole.Items.Add("TKWasASetback");
            ServerComboRole.Items.Add("ZappyBoi");
            ServerComboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            ServerComboRace.Items.Add("Beta4Azeroth");
            ServerComboRace.Items.Add("TKWasASetback");
            ServerComboRace.Items.Add("ZappyBoi");
            ServerComboRace.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //dictionaries and public variables for use

        public static Dictionary<uint, Guild> Guilds = new Dictionary<uint, Guild>();
        public static Dictionary<uint, Player> Players = new Dictionary<uint, Player>();

        public enum Class { Warrior, Mage, Druid, Priest, Warlock, Rogue, Paladin, Hunter, Shaman };

        public enum Race { Orc, Troll, Tauren, Forsaken };

        public enum Role { Tank, Healer, Damage };

        public enum Type { Casual, Questing, Mythic, Raiding, PVP };

        private static uint MAX_LEVEL = 60;

        //guild class declaration

        public class Guild : IComparable
        {

            //guildID attributes and properties

            private readonly uint guildID;
            public uint GID
            {
                get { return guildID; }
            }

            //guildName attributes and properties

            private string gName;
            public string GName
            {
                get { return gName; }
                set { gName = value; }
            }

            //guild Server attributes and properties

            private string gServer;
            public string GServer
            {
                get { return gServer; }
                set { gServer = value; }
            }

            private Type gType;
            public Type GType
            {
                get { return gType; }
                set { gType = value; }
            }

            //default guild constructor

            public Guild()
            {
                guildID = 0;
                gName = "";
                gServer = "";
                gType = 0;
            }

            //Guild constructor to create new guilds

            public Guild(uint newID, string newName, string newServer, Type newGType)
            {
                guildID = newID;
                gName = newName;
                gServer = newServer;
                gType = newGType;
            }

            //CompareTo override for Guild objects to create sorted lists

            public int CompareTo(object alpha)
            {
                if (alpha == null) return 1;

                Guild rightOp = alpha as Guild;

                if (rightOp != null)
                {
                    return gName.CompareTo(rightOp.gName);
                }
                else
                {
                    throw new ArgumentException("[Guild]:CompareTo argument is not a Guild");
                }
            }

            //ToString override for Guild objects, prints formatted output

            public override string ToString()
            {
                return "<" + gName + ">";
            }
        }

        //player class declaration

        public class Player : IComparable
        {
            //playerid attribute and property

            private readonly uint Playerid;
            public uint ID
            {
                get { return Playerid; }

            }

            //playername attribute and property

            private readonly string Playername;
            public string PlayerName
            {
                get { return Playername; }
            }

            //Race attribute and property

            private readonly Race Playerrace;
            public Race PlayerRace
            {
                get { return Playerrace; }
            }

            //level attributes and properties
            private uint level;
            public uint Level
            {
                get
                {
                    return level;
                }
                set
                {
                    level = value;
                }
            }

            //Class attributes and properties

            private Class playerClass;
            public Class PlayerClass
            {
                get { return playerClass; }
                set { playerClass = value; }
            }

            //exp attributes and properties

            private uint exp;
            public uint Exp
            {
                get { return exp; }
                set
                {

                    exp = Exp + value;
                    if ((Exp > Level * 1000 || Exp == Level * 1000) && Level < MAX_LEVEL)
                    {
                        uint RemainingExp = Exp;
                        LevelUp(ref RemainingExp);
                    }
                }
            }

            //level up method increments level when called

            private void LevelUp(ref uint remainingExp)
            {
                remainingExp = (remainingExp - (Level * 1000));
                if (Level < MAX_LEVEL)
                {
                    Level = Level + 1;
                    Console.WriteLine("Ding!");
                    Exp = (uint)-Exp;
                }
                if (remainingExp > (Level * 1000) && Level < MAX_LEVEL)
                {
                    LevelUp(ref remainingExp);
                }

            }

            //CompareTo method to sort player names.

            public int CompareTo(object alpha)
            {
                if (alpha == null) return 1;

                Player rightOp = alpha as Player;

                if (rightOp != null)
                {
                    return Playername.CompareTo(rightOp.Playername);
                }
                else
                {
                    throw new ArgumentException("[Player]:CompareTo argument is not a Player");
                }
            }

            //guildID attributes and properties

            private uint guildID;
            public uint GuildID
            {
                get { return guildID; }
                set { guildID = value; }
            }

            //playerType attributes and properties

            private Role playerRole;
            public Role PlayerRole
            {
                get { return playerRole; }
                set { playerRole = value; }
            }

            //default Player constructor

            public Player()
            {
                Playerid = 0;
                Playername = "";
                Playerrace = 0;
                level = 0;
                exp = 0;
                guildID = 0;
                playerRole = 0;
            }

            //alternate constructor sets all Player variables

            public Player(uint newID, string newName, Race newRace, Class newClass, uint newLevel, uint newExp, uint newGuildID, Role newPlayerRole)
            {
                Playerid = newID;
                Playername = newName;
                Playerrace = newRace;
                playerClass = newClass;
                level = newLevel;
                exp = newExp;
                guildID = newGuildID;
                playerRole = newPlayerRole;
            }

            //ToString override prints player information to the output box

            public override string ToString()
            {
                Guild GuildName = new Guild();

                bool GuildFound;
                //if player is not in a guild
                if (GuildID != 0 && Guilds.TryGetValue(GuildID, out GuildName))
                {
                    GuildFound = Guilds.TryGetValue(GuildID, out GuildName);
                    //check for things to be too short
                    if (Playername.Length < 8)
                    {
                        if (PlayerRace.ToString().Length < 7)
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' + '\t' + "( " + playerClass + "\t" + " - " + playerRole + " )" + "\t" + "Race: " + Playerrace + '\t' + '\t' + "Level: " + level + '\t' + "Guild: " + GuildName;
                            }
                            //Class isn't too short
                            else
                            {
                                return "Name: " + Playername + '\t' + '\t' + "( " + playerClass + " - " + playerRole + " )" + "\t" + "Race: " + Playerrace + '\t' + '\t' + "Level: " + level + '\t' + "Guild: " + GuildName;
                            }

                        }
                        //Race isn't too short
                        else
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' + '\t' + "( " + playerClass + "\t" + " - " + playerRole + " )" + "\t" + "Race: " + Playerrace + '\t' + "Level: " + level + '\t' + "Guild: " + GuildName;
                            }
                            //Class isn't too short
                            else
                            {
                                return "Name: " + Playername + '\t' + '\t' +"( " + playerClass + " - " + playerRole + " )" + "\t" + "Race: " + Playerrace + '\t' + "Level: " + level + '\t'  + "Guild: " + GuildName;
                            }

                        }
                    }
                    //Player Name isn't too short
                    else
                    {
                        if (PlayerRace.ToString().Length < 7)
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' +"( " + playerClass + '\t' + " - " + playerRole + " )" + "\t" + "Race: " + Playerrace + '\t' + '\t'  + "Level: " + level + '\t' + "Guild: " + GuildName;
                            }
                            //Class isn't too short
                            else
                            {
                                return "Name: " + Playername + '\t' + "( " + playerClass + " - " + playerRole + " )" + "\t" +  "Race: " + Playerrace + '\t' + '\t' + "Level: " + level + '\t' + "Guild: " + GuildName;
                            }
                        }
                        //Race isn't too short
                        else
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' + "( " + playerClass + "\t" + " - " + playerRole + " )" + "\t" + "Race: " + Playerrace + '\t' + "Level: " + level + '\t' + "Guild: " + GuildName;
                            }
                            else
                            {
                                //Class isn't too short
                                return "Name: " + Playername + '\t' + "( " + playerClass + " - " + playerRole + " )" + "\t" + "Race: " + Playerrace + '\t' + "Level: " + level + '\t' + "Guild: " + GuildName;
                            }
                        }
                    }
                }
                //Player is not in a guild
                else
                {
                    if (Playername.Length < 8)
                    {
                        if (PlayerRace.ToString().Length < 7)
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' + '\t' + "Race: " + Playerrace + '\t' + '\t' + "Class: " + PlayerClass + '\t' + '\t' + "Level: " + level;
                            }
                            else
                            {
                                //Class isn't too short
                                return "Name: " + Playername + '\t' + '\t' + "Race: " + Playerrace + '\t' + '\t' + "Class: " + PlayerClass + '\t' + "Level: " + level;
                            }

                        }
                        //Race isn't too short
                        else
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' + "Race: " + Playerrace + '\t' + "Class: " + PlayerClass + '\t' + '\t' + "Level: " + level;
                            }
                            else
                            {
                                //Class isn't too short
                                return "Name: " + Playername + '\t' + "Race: " + Playerrace + '\t' + "Class: " + PlayerClass + '\t' + "Level: " + level;
                            }

                        }
                    }
                    //Player Name isn't too short
                    else
                    {
                        if (PlayerRace.ToString().Length < 5)
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' + "Race: " + Playerrace + '\t' + '\t' + "Class: " + PlayerClass + '\t' + '\t' + "Level: " + level + '\t' + '\t' + "Guild: " + GuildName;
                            }
                            else
                            {
                                //Class isn't too short
                                return "Name: " + Playername + '\t' + "Race: " + Playerrace + '\t' + '\t' + "Class: " + PlayerClass + '\t' + "Level: " + level + '\t' + '\t' + "Guild: " + GuildName;
                            }
                        }
                        //Race isn't too short
                        else
                        {
                            if (PlayerClass.ToString().Length < 5)
                            {
                                return "Name: " + Playername + '\t' + "Race: " + Playerrace + '\t' + "Class: " + PlayerClass + '\t' + '\t' + "Level: " + level + '\t' + '\t' + "Guild: " + GuildName;
                            }
                            else
                            {
                                //Class isn't too short
                                return "Name: " + Playername + '\t' + "Race: " + Playerrace + '\t' + "Class: " + PlayerClass + '\t' + "Level: " + level + '\t' + '\t' + "Guild: " + GuildName;
                            }
                        }
                    }
                }
            }
        }

        private void LoadClassBox()
        {
            Class tempClass = new Class { };
            for (int i = 0; i < 9; i++)
            {
                tempClass = (Class)i;
                ClassComboClass.Items.Add(tempClass);
            }
            ClassComboClass.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //LoadDicts method controls reading files, creating objects, and organization
        //calls methods to implement various functions

        private void LoadDicts()
        {
            string readfile, guildfile, tempName = "";
            uint tempID = 0, tempLevel = 0, tempExp = 0, tempGuildID = 0;
            Race tempRace = new Race { };
            Class tempClass = new Class { };

            //Players read loop

            using (StreamReader inFile = new StreamReader("players.txt"))
            {
                readfile = inFile.ReadLine(); // I remembered to prime the read
                while (readfile != null)
                {
                    SplitPlayer(readfile, tempID, tempName, tempRace, tempClass, tempLevel, tempExp, tempGuildID);
                    readfile = inFile.ReadLine();
                }
            }

            using (StreamReader inFile2 = new StreamReader("guilds.txt"))
            {
                guildfile = inFile2.ReadLine();
                while (guildfile != null)
                {
                    SplitGuild(guildfile);
                    guildfile = inFile2.ReadLine();
                }
            }
        }

        //SplitGuild method builds the guild dictionary

        private static void SplitGuild(string guildfile)
        {
            string[] splitter = guildfile.Split('-', '\t');
            string guildName = splitter[2];
            string guildServer = splitter[3];
            Type GType = new Type { };
            Type.TryParse(splitter[1], out GType);
            Guilds.Add(Convert.ToUInt32(splitter[0]), new Guild(Convert.ToUInt32(splitter[0]), guildName, guildServer, GType));
        }

        private static void SplitPlayer(string readfile, uint tempID, string tempName, Race tempRace, Class tempClass, uint tempLevel, uint tempExp, uint tempGuildID)
        {
            string[] splitter = readfile.Split('\t');
            Role tempRole = new Role { };
            for (int i = 0; i < splitter.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        tempID = Convert.ToUInt32(splitter[i]);
                        break;
                    case 1:
                        tempName = splitter[i];
                        break;
                    case 2:
                        Race.TryParse(splitter[i], out tempRace);
                        break;
                    case 5:
                        tempLevel = Convert.ToUInt32(splitter[i]);
                        break;
                    case 3:
                        Class.TryParse(splitter[i], out tempClass);
                        break;
                    case 4:
                        Role.TryParse(splitter[i], out tempRole);
                        break;
                    case 6:
                        tempExp = Convert.ToUInt32(splitter[i]);
                        break;
                    case 7:
                        tempGuildID = Convert.ToUInt32(splitter[i]);
                        break;
                }
            }
            Players.Add(tempID, new Player(tempID, tempName, tempRace, tempClass, tempLevel, tempExp, tempGuildID, tempRole));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ServerComboRace.SelectedIndex == -1)
            {
                OutputBox.Clear();
                OutputBox.AppendText("Please Select a Server Before Querying");
                return;
            }

            var GuildQuery =
                from N in Guilds
                where N.Value.GServer.ToString().CompareTo(ServerComboRace.SelectedItem.ToString()) == 0
                select N.Value.GID;

            var PlayerQuery =
                from N in Players
                from M in GuildQuery
                where N.Value.GuildID == M
                select N.Value;

            int PlayerTotal = 0;

            foreach( Player i in PlayerQuery)
            {
                PlayerTotal++;
            }

            var RaceQuery1 =
                from S in PlayerQuery
                where S.PlayerRace.ToString().CompareTo("Tauren") == 0
                select S;

            var RaceQuery2 =
                from S in PlayerQuery
                where S.PlayerRace.ToString().CompareTo("Orc") == 0
                select S;

            var RaceQuery3 =
                from S in PlayerQuery
                where S.PlayerRace.ToString().CompareTo("Forsaken") == 0
                select S;

            var RaceQuery4 =
                from S in PlayerQuery
                where S.PlayerRace.ToString().CompareTo("Troll") == 0
                select S;

            int PlayerCount1 = RaceQuery1.Count(), PlayerCount2 = RaceQuery2.Count(), PlayerCount3 = RaceQuery3.Count(), PlayerCount4 = RaceQuery4.Count();

            double Player1Percent = 0.00, Player2Percent = 0.00, Player3Percent = 0.00, Player4Percent = 0.00 ;
            Player1Percent = Convert.ToDouble(PlayerCount1) / Convert.ToDouble(PlayerTotal);
            Player1Percent = Player1Percent * 100;
            Player1Percent = Math.Truncate(Player1Percent * 100) / 100;

            Player2Percent = Convert.ToDouble(PlayerCount2) / Convert.ToDouble(PlayerTotal);
            Player2Percent = Player2Percent * 100;
            Player2Percent = Math.Truncate(Player2Percent * 100) / 100;

            Player3Percent = Convert.ToDouble(PlayerCount3) / Convert.ToDouble(PlayerTotal);
            Player3Percent = Player3Percent * 100;
            Player3Percent = Math.Truncate(Player3Percent * 100) / 100;

            Player4Percent = Convert.ToDouble(PlayerCount4) / Convert.ToDouble(PlayerTotal);
            Player4Percent = Player4Percent * 100;
            Player4Percent = Math.Truncate(Player4Percent * 100) / 100;

            OutputBox.Clear();
            OutputBox.AppendText("Race Percentage For " + ServerComboRace.SelectedItem.ToString() + ":" + "\n");
            for (int i = 0; i < 75; i++)
                OutputBox.AppendText("-");
            OutputBox.AppendText("\n");
            OutputBox.AppendText("Orc:      " + Player2Percent.ToString() + "%" + "\n");
            OutputBox.AppendText("Troll:    " + Player4Percent.ToString() + "%" + "\n");
            OutputBox.AppendText("Tauren:   " + Player1Percent.ToString() + "%" + "\n");           
            OutputBox.AppendText("Forsaken: " + Player3Percent.ToString() + "%" + "\n");
            OutputBox.AppendText("\nEND RESULTS\n");
            for (int i = 0; i < 75; i++)
                OutputBox.AppendText("-");
            OutputBox.AppendText("\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(TypeComboGuild.SelectedIndex == -1)
            {
                OutputBox.Clear();
                OutputBox.AppendText("Please Select a Type Before Querying");
            }
            else
            {
                OutputBox.Clear();

                var GuildTypeQuery =
                    from N in Guilds
                    where N.Value.GType.ToString().CompareTo(TypeComboGuild.SelectedItem.ToString()) == 0
                    group N.Value.GName
                    by N.Value.GServer into g
                    select new { GServer = g, GName = g.ToList() };

                int j = 0, k = 0;
                OutputBox.AppendText("All " + TypeComboGuild.SelectedItem.ToString() + "-Type Guilds");
                OutputBox.AppendText("\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");
                foreach (var i in GuildTypeQuery)
                {
                    OutputBox.AppendText(i.GServer.Key.ToString() + "\n");
                    foreach(string g in i.GServer)
                    {
                        OutputBox.AppendText("\t" + "<" + i.GName[j].ToString() + ">" + "\n");
                        j++;
                    }
                    j = 0;
                    k++;
                }
                OutputBox.AppendText("\n");
                OutputBox.AppendText("END RESULTS\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TankRadio.Checked == true)
            {
                OutputBox.Clear();
                

                OutputBox.AppendText("All Eligible Players Not Fulfilling The Tank Role");
                OutputBox.AppendText("\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");

                var PlayerQuery =
                    from N in Players
                    orderby N.Value.PlayerName ascending
                    orderby N.Value.Level ascending
                    select N.Value;
                    

                var TankQuery1 =
                    from S in PlayerQuery
                    where S.PlayerClass.ToString().CompareTo("Warrior") == 0 || S.PlayerClass.ToString().CompareTo("Druid") == 0 || S.PlayerClass.ToString().CompareTo("Paladin") == 0
                    select S;

                var RoleQuery1 =
                    from S in TankQuery1
                    where S.PlayerRole.ToString().CompareTo("Damage") == 0 || S.PlayerRole.ToString().CompareTo("Healer") == 0
                    select S;

                foreach (Player i in RoleQuery1)
                {
                    if (i.PlayerName.Length <= 7)
                    {
                        OutputBox.AppendText("Name: " + i.PlayerName);
                        OutputBox.AppendText("\t" + "\t" + "( " + i.PlayerClass + "  -  " + i.PlayerRole + ")");
                        if (Convert.ToString(i.PlayerClass).Length <= 5)
                        {
                            OutputBox.AppendText("\t" + "\t" + "Race: " + i.PlayerRace + "\t");
                            OutputBox.AppendText("Level: " + i.Level);
                        }
                        else
                        {
                            OutputBox.AppendText("\t" + "Race: " + i.PlayerRace + "\t");
                            OutputBox.AppendText("Level: " + i.Level);
                        }

                        foreach (var key in Guilds)
                        {
                            if (i.GuildID == key.Value.GID)
                                OutputBox.AppendText("  <" + key.Value.GName.ToString() + ">");
                        }
                        //OutputBox.AppendText("  <" + i.GuildID.ToString()+ ">");
                        OutputBox.AppendText("\n");
                    }

                    else if (i.PlayerName.Length > 7)
                    {
                        OutputBox.AppendText("Name: " + i.PlayerName);
                        OutputBox.AppendText("\t" + "( " + i.PlayerClass + "  -  " + i.PlayerRole + ")");
                        OutputBox.AppendText("\t" + "Race: " + i.PlayerRace + "\t");
                        OutputBox.AppendText("Level: " + i.Level);
                        foreach (var key in Guilds)
                        {
                            if (i.GuildID == key.Value.GID)
                                OutputBox.AppendText("  <" + key.Value.GName.ToString() + ">");
                        }
                        //OutputBox.AppendText("  <" + i.GuildID.ToString()+ ">");
                        OutputBox.AppendText("\n");
                    }
                }
                OutputBox.AppendText("\n");
                OutputBox.AppendText("END RESULTS\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");
            }
            else if (HealerRadio.Checked == true)
            {
                OutputBox.Clear();
                OutputBox.AppendText("All Eligible Players Not Fulfilling The Healer Role");
                OutputBox.AppendText("\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");

                var PlayerQuery =
                    from M in Players
                    orderby M.Value.PlayerName ascending
                    orderby M.Value.Level ascending
                    select M.Value;

                var HealerQuery1 =
                    from O in PlayerQuery
                    where O.PlayerClass.ToString().CompareTo("Druid") == 0 || O.PlayerClass.ToString().CompareTo("Paladin") == 0 || O.PlayerClass.ToString().CompareTo("Shaman") == 0 || O.PlayerClass.ToString().CompareTo("Priest") == 0
                    select O;

                var RoleQuery2 =
                    from L in HealerQuery1
                    where L.PlayerRole.ToString().CompareTo("Healer") != 0
                    select L;


                foreach (Player i in RoleQuery2)
                {
                    OutputBox.AppendText("Name: " + i.PlayerName);
                    if (i.PlayerName.Length >= 8)
                    {
                        OutputBox.AppendText("\t");
                    }
                    else
                        OutputBox.AppendText("\t" + "\t");

                    OutputBox.AppendText("(" + i.PlayerClass + "  -  " + i.PlayerRole + ")");

                    OutputBox.AppendText("\t");

                    OutputBox.AppendText("Race: " + i.PlayerRace);
                    if(Convert.ToString(i.PlayerRace).Length >= 8)
                    {
                        OutputBox.AppendText("\t");
                    }
                    else
                    OutputBox.AppendText("\t" + "\t");

                    OutputBox.AppendText("Level: " + i.Level);
                    foreach (var key in Guilds)
                    {
                        if (i.GuildID == key.Value.GID)
                            OutputBox.AppendText("\t"  + "<" + key.Value.GName.ToString() + ">");
                    }
                    //OutputBox.AppendText("  <" + i.GuildID.ToString()+ ">");
                    OutputBox.AppendText("\n");

                }
                OutputBox.AppendText("\n");
                OutputBox.AppendText("END RESULTS\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");


            }

            else if (DamageRadio.Checked == true)
            {
                OutputBox.Clear();
                OutputBox.AppendText("All Eligible Players Not Fulfilling The Damage Role");
                OutputBox.AppendText("\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");


                var PlayerQuery =
                    from M in Players
                    orderby M.Value.PlayerName ascending
                    orderby M.Value.Level ascending
                    select M.Value;


                var RoleQuery2 =
                    from L in PlayerQuery
                    where L.PlayerRole.ToString().CompareTo("Damage") != 0
                    select L;

                foreach (Player i in RoleQuery2)
                {
                    OutputBox.AppendText("Name: " + i.PlayerName);

                    if (i.PlayerName.Length >= 8)
                    {
                        OutputBox.AppendText("\t");
                    }
                    else
                        OutputBox.AppendText("\t" + "\t");

                    OutputBox.AppendText("(" + i.PlayerClass + "  -  " + i.PlayerRole + ")");
                    OutputBox.AppendText("\t");

                    OutputBox.AppendText("Race: " + i.PlayerRace);
                    if (Convert.ToString(i.PlayerRace).Length >= 8)
                    {
                        OutputBox.AppendText("\t");
                    }
                    else
                        OutputBox.AppendText("\t" + "\t");

                    OutputBox.AppendText("Level: " + i.Level);
                    foreach (var key in Guilds)
                    {
                        if (i.GuildID == key.Value.GID)
                            OutputBox.AppendText("  <" + key.Value.GName.ToString() + ">");
                    }
                    //OutputBox.AppendText("  <" + i.GuildID.ToString()+ ">");
                    OutputBox.AppendText("\n");

                }
            

                OutputBox.AppendText("\n");
                OutputBox.AppendText("END RESULTS\n");
                OutputBox.AppendText("--------------------------------------------------------------------\n");


            }
            else if (TankRadio.Checked == false && HealerRadio.Checked == false && DamageRadio.Checked == false)
            {
                OutputBox.Clear();
                OutputBox.AppendText("Please select a Radio Button.");
            }
        }

            private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClassTypesButton_Click(object sender, EventArgs e)
        {
            if(ClassComboClass.SelectedIndex == -1)
            {
                OutputBox.Clear();
                OutputBox.AppendText("Please Select a Class before Querying");
            }
            else if(ServerComboClass.SelectedIndex == -1)
            {
                OutputBox.Clear();
                OutputBox.AppendText("Please Select a Server before Querying");
            }
            else
            {
                OutputBox.Clear();

                var GuildQuery =
                    from M in Players
                    where M.Value.PlayerClass.ToString().CompareTo(ClassComboClass.SelectedItem.ToString()) == 0
                    select M.Value;

                var PlayerClassQuery =
                    from M in GuildQuery
                    from N in Guilds
                    where N.Value.GServer.CompareTo(ServerComboClass.SelectedItem.ToString()) == 0
                    where M.GuildID == N.Value.GID
                    orderby M.Level ascending
                    select M;

                if (!PlayerClassQuery.Any())
                {
                    OutputBox.AppendText("No results for " + ClassComboClass.SelectedItem.ToString() + "s in " + ServerComboClass.SelectedItem.ToString() + "\n");
                    return;
                }

                OutputBox.AppendText("All " + ClassComboClass.SelectedItem.ToString() + "s in " + ServerComboClass.SelectedItem.ToString() + "\n");
                for (int i = 0; i < 75; i++)
                    OutputBox.AppendText("-");
                OutputBox.AppendText("\n");

                foreach (Player i in PlayerClassQuery)
                {
                    OutputBox.AppendText(i.ToString() + "\n");
                }
                OutputBox.AppendText("\nEND RESULTS\n");
                for (int i = 0; i < 75; i++)
                    OutputBox.AppendText("-");
                OutputBox.AppendText("\n");
            }
        }

        private void ServerComboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaxNumeric_ValueChanged_1(object sender, EventArgs e)
        {
            MaxNumeric_ValueChanged(sender, e);
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoleTypesButton_Click(object sender, EventArgs e)
        {
            if(RoleComboRole.SelectedIndex == -1)
            {
                OutputBox.Clear();
                OutputBox.AppendText("Please Select a Role Before Querying");
            }
            else if(ServerComboRole.SelectedIndex == -1)
            {
                OutputBox.Clear();
                OutputBox.AppendText("Please Select a Server Before Querying");
            }
            else
            {
                OutputBox.Clear();

                var GuildQuery =
                    from M in Guilds
                    where M.Value.GServer.ToString().CompareTo(ServerComboRole.SelectedItem.ToString()) == 0
                    select M.Value;

                var PlayerRoleQuery =
                    from M in GuildQuery
                    from N in Players
                    where N.Value.PlayerRole.ToString().CompareTo(RoleComboRole.SelectedItem.ToString()) == 0
                    where M.GID == N.Value.GuildID
                    where N.Value.Level >= MinNumeric.Value
                    where N.Value.Level <= MaxNumeric.Value
                    orderby N.Value.Level ascending
                    select N.Value;

                if (!PlayerRoleQuery.Any())
                {
                    OutputBox.AppendText("No Results for " + RoleComboRole.SelectedItem.ToString() + "s From Level " + MinNumeric.Value.ToString() + " to " + MaxNumeric.Value.ToString() + " in " + ServerComboRole.SelectedItem.ToString() +  "\n");
                    return;
                }

                OutputBox.AppendText("All " + RoleComboRole.SelectedItem.ToString() + "s From Level " + MinNumeric.Value.ToString() + " to " + MaxNumeric.Value.ToString() + " in " + ServerComboRole.SelectedItem.ToString() + "\n");
                for (int i = 0; i < 75; i++)
                    OutputBox.AppendText("-");
                OutputBox.AppendText("\n");

                foreach (Player i in PlayerRoleQuery)
                {
                    OutputBox.AppendText(i.ToString() + "\n");
                }
                OutputBox.AppendText("\nEND RESULTS\n");
                for (int i = 0; i < 75; i++)
                    OutputBox.AppendText("-");
                OutputBox.AppendText("\n");
            }

        }

        private void MaxLevelPercentButton_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            OutputBox.AppendText("Percentage of Max Level Players in All Guilds");
            OutputBox.AppendText("\n");
            OutputBox.AppendText("-----------------------------------------------------");
            OutputBox.AppendText("\n");


            foreach (var key in Guilds)
            {
                int PlayerTotal = 0;

                var GuildQuery =
                    from N in Guilds
                    where N.Value.GID.CompareTo(key.Value.GID) == 0
                    select N.Value.GID;

                var PlayerQuery =
                    from N in Players
                    from M in GuildQuery
                    where N.Value.GuildID == M
                    select N.Value;

                var MaxLevelQuery =
                    from S in PlayerQuery
                    where S.Level >= 60
                    select S;

                foreach (Player i in PlayerQuery)
                {
                    PlayerTotal++;
                }

                int PlayerCount1 = MaxLevelQuery.Count();
                double GuildPercent = 0.00;

                GuildPercent = Convert.ToDouble(PlayerCount1) / Convert.ToDouble(PlayerTotal);
                GuildPercent = GuildPercent * 100;
                GuildPercent = Math.Truncate(GuildPercent * 100) / 100;

                if (GuildPercent >= 0)
                {
                    foreach (var dan in Guilds)
                    {
                        if (dan.Value.GID.CompareTo(key.Value.GID) == 0)
                        {
                            OutputBox.AppendText("<");
                            OutputBox.AppendText(Convert.ToString(dan.Value.GName));
                            if(Convert.ToString(dan.Value.GName).Length <= 8)
                            {
                                OutputBox.AppendText(">" + "\t" + "\t" + "\t");
                            }
                            else if (Convert.ToString(dan.Value.GName).Length >= 19)
                            {
                                OutputBox.AppendText(">" + "\t");
                            }
                            else
                            OutputBox.AppendText(">" + "\t" + "\t");
                        }
                    }
                    OutputBox.AppendText(GuildPercent.ToString() + "%" + "\n");
                }
            }

            OutputBox.AppendText("\nEND RESULTS\n");
            OutputBox.AppendText("-----------------------------------------------------");

        }

        private void ServerComboRace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
