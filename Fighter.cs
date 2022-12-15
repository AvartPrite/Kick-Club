class Fighter{
    private int hp, str;
    public Fighter(int _hp, int _str){
        hp = _hp;
        str = _str; 
    }
    public int HP{
        get => hp;
        set => hp = value;
    } 
    public int Str{
        get => str;
        set => str = value;
    }
}