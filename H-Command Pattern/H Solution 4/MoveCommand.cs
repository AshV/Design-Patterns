﻿namespace H_Solution_4
{
    public class MoveCommand : AbstractCommand
    {
        private int j;
        private int k;

        public MoveCommand(Square square, int j, int k) : base(square)
        {
            this.j = j;
            this.k = k;
        }

        public override void execute()
        {
            square.move(j, k);
        }

        public override void undo()
        {
            square.move_undo(j, k);
        }
    }
}