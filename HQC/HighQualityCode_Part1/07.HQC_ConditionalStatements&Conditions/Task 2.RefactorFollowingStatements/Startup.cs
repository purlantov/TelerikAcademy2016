﻿namespace Task_2.RefactorFollowingStatements
{
    using Task_2.RefactorFollowingStatements.VisitCell;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var cooker = new Cooker();
            var potato = new Potato();

            cooker.CheckIfPotatoIsReadyForCooking(potato);

            var cellVisitor = new VisitCells();

            cellVisitor.VisitedCell();
        }
    }
}
