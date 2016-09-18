namespace HQC_NamingIdentifiers.Task2.Make_Чуек
{
    class HumanFactory
    {
       
        public void MakeHuman(int ID)
        {
            Human newHuman = new Human();
            newHuman.Age = ID;
            if (ID % 2 == 0)
            {
                newHuman.humanName = "Батката";
                newHuman.gender = GenderType.UltraBadAssMale;
            }
            else
            {
                newHuman.humanName = "Мацето";
                newHuman.gender = GenderType.Banbina;
            }
        }
    }
}
