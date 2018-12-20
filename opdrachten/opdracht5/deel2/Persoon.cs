using System;

namespace deel2
{

  public class Persoon : Gebruiker, IInformatie 
  {
    private string naam;
    private string voornaam;
    public string Naam 
    {
      get 
      {
        return this.naam;
      }
      set
      {
        this.naam = value;
      }
    }
    public string Voornaam
    {
      get 
      {
        return this.voornaam;
      }
      set 
      {
        this.voornaam = value;
      }
    }
    public string VolledigeNaam {get;}
    // using System, kan Date niet vinden
    public DateTime Geboortedatum {get; set;}

    public int Leeftijd()
    {
      return 99;
    }

    public override string GenereerWachtwoord() {
      return "Persoon - wachtwoord";
    }

    public string GenereerWachtwoord(string input) {
      return input;
    }

    // Kan niet overriden op return type. Functie hieronder throwt error. Functie bestaat al binnen klasse.

    // public override int GenereerWachtwoord() {
    //   return 1286792;
    // }

    public int GenereerWachtwoord(int input) {
      return input;
    }

    public string String() {
      return "Persoon";
    }
  }
}