class Fordon{

    public Fordon(string Nyttmärke) {
        Märke = Nyttmärke;
    }

    public Fordon(){
        
    }
    private string märke; 
    public string Märke{
        get{
            return märke; 
        }
        set{
            märke = value; 
        }
    }
}