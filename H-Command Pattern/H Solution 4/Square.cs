namespace H_Solution_4
{
    public class Square
    {
        private int id;
        private int length;
        private int x;
        private int y;

        public Square(int id, int length)
        {
            this.id = id;
            this.length = length;
            this.x = 0;
            this.y = 0;
        }

        public void move(int j, int k)
        {
            x += j;
            y += k;
        }

        public void move_undo(int j, int k)
        {
            x -= j;
            y -= k;
        }

        public void scale(int j)
        {
            length *= j;
        }

        public void scale_undo(int j)
        {
            length /= j;
        }

        public override string ToString()
        {
            return "Square [id=" + id + ", length=" + length + ", x=" + x + ", y=" + y + "]";
        }
    }
}