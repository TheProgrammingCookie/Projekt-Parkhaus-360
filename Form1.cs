using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

public class MyData
{
    public string Fahrzeugart { get; set; }
    public string Kennzeichen { get; set; }
    public int Besetzt { get; set; }
}




namespace Projekt_360_Parkhaus
{


    public partial class Form1 : Form
    {
        // Variablen Deklaration
        public static int Etagen = 0;
        public static int Parkplaetze = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnBeenden_Click(object sender, EventArgs e)
        {
            // Die Application wird Beendet
            System.Windows.Forms.Application.ExitThread();

        }

        private void btnBestätigen_Click(object sender, EventArgs e)
        {


            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "ParkhausDaten.json");
            string AlphabetEtage = "A";





            // Überprüfen, ob die Datei bereits vorhanden ist
            if (File.Exists(filePath))
            {
                // Lösche die bestehende Datei, damit falsche Parkhauseinträge keine Probleme bereiten
                File.Delete(filePath);
            }



            {

                Etagen = int.Parse(txtbEingabeEtagen.Text);
                Parkplaetze = int.Parse(txtbEingabeParkplaetze.Text);
                // Hier werden alle Einträge Neu eingetragen

                for (int i = 1; i < (Etagen + 1); i++)
                {
                    // Hier werden der Etagen bis zur 
                    switch (i)
                    {
                        case 1:
                            AlphabetEtage = "A";
                            break;

                        case 2:
                            AlphabetEtage = "B";
                            break;


                        case 3:
                            AlphabetEtage = "C";
                            break;
                        case 4:
                            AlphabetEtage = "D";
                            break;
                        case 5:
                            AlphabetEtage = "E";
                            break;
                        case 6:
                            AlphabetEtage = "F";
                            break;
                        case 7:
                            AlphabetEtage = "G";
                            break;
                        case 8:
                            AlphabetEtage = "H";
                            break;
                        case 9:
                            AlphabetEtage = "I";
                            break;
                        case 10:
                            AlphabetEtage = "J";
                            break;
                        case 11:
                            AlphabetEtage = "K";
                            break;
                        case 12:
                            AlphabetEtage = "L";
                            break;
                        case 13:
                            AlphabetEtage = "M";
                            break;
                        case 14:
                            AlphabetEtage = "N";
                            break;
                        case 15:
                            AlphabetEtage = "O";
                            break;
                        case 16:
                            AlphabetEtage = "P";
                            break;
                        case 17:
                            AlphabetEtage = "Q";
                            break;
                        case 18:
                            AlphabetEtage = "R";
                            break;
                        case 19:
                            AlphabetEtage = "S";
                            break;
                        case 20:
                            AlphabetEtage = "T";
                            break;


                    }



                    for (int i1 = 1; i1 < (Parkplaetze + 1); i1++)
                    {
                        string sectionName = AlphabetEtage + Convert.ToString(i1);
                        var newSection = new
                        {
                            Kennzeichen = "K.A",
                            Fahrzeugart = "K.A",
                            Besetzt = "0"
                        };

                        string json = "";
                        // Überprüfen, ob die Datei bereits existiert
                        if (File.Exists("ParkhausDaten.json"))
                        {
                            // Lesen des Inhalts der Datei
                            using (StreamReader reader = new StreamReader("ParkhausDaten.json"))
                            {
                                json = reader.ReadToEnd();
                            }

                            // Deserialisieren des JSON-Strings in ein JSON-Objekt
                            var obj = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                            // Hinzufügen der neuen Sektion
                            obj[sectionName] = newSection;

                            // Serialisieren des JSON-Objekts in einen JSON-String
                            json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                        }
                        else
                        {
                            // Erstellen des JSON-Objekts
                            var obj = new Dictionary<string, object>
                            {
                             { sectionName, newSection }
                            };

                            // Serialisieren des JSON-Objekts in einen JSON-String
                            json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                        }

                        // Schreiben von JSON-Daten in eine Datei
                        using (StreamWriter writer = new StreamWriter("ParkhausDaten.json"))
                        {
                            writer.Write(json);
                        }
                    }



                }



            }





            // Das Fenster mit dem Verwalten der Fahrzeuge und des Parkhauses soll nun geöffnet werden
            // Das vorherige soll in den Hintergrund verschwinden


            FVerwaltung formverwaltung = new FVerwaltung();
            formverwaltung.Show();



            this.Hide();





        }

        private void txtbEingabeEtagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbEingabeParkplaetze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



}

