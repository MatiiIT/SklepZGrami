using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZGramiBiblioteka
{
    public static class DaneStartowe
    {
        public static void Zaladuj(Sklep sklep)
        {
            sklep.DodajProdukt(new Gra(
                1,
                "Wiedźmin 3",
                129.99m,
                "CD Projekt RED",
                20,
                GatunekGry.RPG,
                Platforma.PC,
                18));

            sklep.DodajProdukt(new Akcesoria(
                2,
                "Pad Xbox",
                249.99m,
                "Microsoft",
                7,
                "Kontroler"));

            sklep.DodajProdukt(new Gra(
                3,
                "Counter-Strike 2",
                79.99m,
                "Valve",
                30,
                GatunekGry.FPS,
                Platforma.PC,
                16));

            sklep.DodajProdukt(new DodatekDLC(
                4,
                "Krew i Wino",
                79.99m,
                "CD Projekt RED",
                8,
                "Wiedźmin 3"));

            sklep.DodajProdukt(new Gra(
                5,
                "FIFA 26",
                269.99m,
                "EA Sports",
                18,
                GatunekGry.Sportowa,
                Platforma.PlayStation,
                3));

            sklep.DodajProdukt(new Akcesoria(
                6,
                "Słuchawki gamingowe",
                179.99m,
                "HyperX",
                12,
                "Słuchawki"));

            sklep.DodajProdukt(new Gra(
                7,
                "Horizon Zero Dawn",
                149.99m,
                "Guerrilla Games",
                15,
                GatunekGry.Przygodowa,
                Platforma.PlayStation,
                16));

            sklep.DodajProdukt(new DodatekDLC(
                8,
                "Widmo Wolności",
                99.99m,
                "CD Projekt RED",
                6,
                "Cyberpunk 2077"));

            sklep.DodajProdukt(new Akcesoria(
                9,
                "Myszka Logitech G502",
                219.99m,
                "Logitech",
                10,
                "Myszka"));

            sklep.DodajProdukt(new Gra(
                10,
                "Darkest Dungeon",
                89.99m,
                "Red Hook Studios",
                10,
                GatunekGry.Strategia,
                Platforma.PC,
                16));

            sklep.DodajProdukt(new Gra(
                11,
                "Tomb Raider",
                139.99m,
                "Square Enix",
                9,
                GatunekGry.Przygodowa,
                Platforma.Xbox,
                18));

            sklep.DodajProdukt(new Akcesoria(
                12,
                "Klawiatura mechaniczna",
                299.99m,
                "SteelSeries",
                6,
                "Klawiatura"));

            sklep.DodajProdukt(new Gra(
                13,
                "Cuphead",
                89.99m,
                "Studio MDHR",
                13,
                GatunekGry.Przygodowa,
                Platforma.PC,
                7));

            sklep.DodajProdukt(new DodatekDLC(
                14,
                "Serce z kamienia",
                49.99m,
                "CD Projekt RED",
                10,
                "Wiedźmin 3"));

            sklep.DodajProdukt(new Gra(
                15,
                "Call of Duty Black Ops 6",
                299.99m,
                "Activision",
                12,
                GatunekGry.FPS,
                Platforma.Xbox,
                18));

            sklep.DodajProdukt(new Akcesoria(
                16,
                "Podkładka gamingowa XL",
                59.99m,
                "Genesis",
                25,
                "Podkładka"));

            sklep.DodajProdukt(new Gra(
                17,
                "Super Mario Odyssey",
                219.99m,
                "Nintendo",
                16,
                GatunekGry.Przygodowa,
                Platforma.NintendoSwitch,
                7));

            sklep.DodajProdukt(new Gra(
                18,
                "Golf With Your Friends",
                49.99m,
                "Team17",
                14,
                GatunekGry.Sportowa,
                Platforma.PC,
                3));

            sklep.DodajProdukt(new Akcesoria(
                19,
                "Kamera internetowa",
                159.99m,
                "Creative",
                5,
                "Kamera"));

            sklep.DodajProdukt(new Gra(
                20,
                "Balatro",
                59.99m,
                "LocalThunk",
                25,
                GatunekGry.Strategia,
                Platforma.PC,
                12));

            sklep.DodajProdukt(new Gra(
                21,
                "Bloodborne",
                119.99m,
                "FromSoftware",
                8,
                GatunekGry.RPG,
                Platforma.PlayStation,
                18));

            sklep.DodajProdukt(new Akcesoria(
                22,
                "Ładowarka do padów",
                89.99m,
                "Trust",
                9,
                "Ładowarka"));

            sklep.DodajProdukt(new Gra(
                23,
                "The Binding of Isaac",
                69.99m,
                "Nicalis",
                17,
                GatunekGry.Strategia,
                Platforma.PC,
                16));

            sklep.DodajProdukt(new DodatekDLC(
                24,
                "Shadow of the Erdtree",
                179.99m,
                "FromSoftware",
                7,
                "Elden Ring"));

            sklep.DodajKlienta(new Klient(
                "Artur",
                "Adamski",
                "artur@gmail.com"));

            sklep.DodajKlienta(new Klient(
                "Barbara",
                "Borkowska",
                "barbara@gmail.com"));

            sklep.DodajKlienta(new Klient(
                "Cezary",
                "Czajka",
                "cezary@gmail.com"));

            sklep.DodajKlienta(new Klient(
                "Daria",
                "Dmowska",
                "daria@gmail.com"));

            sklep.DodajKlienta(new Klient(
                "Emilia",
                "Eklerka",
                "emilia@gmail.com"));

            sklep.DodajKlienta(new Klient(
                "Filip",
                "Frankowski",
                "filip@gmail.com"));
        }
    }
}
