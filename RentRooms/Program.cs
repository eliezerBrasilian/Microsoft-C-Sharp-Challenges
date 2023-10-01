namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int roomsQuantity = 10;
            int roomsRented = 1;
            Room[] rooms = new Room[roomsQuantity];

            fillRooms(roomsRented,rooms);
            showBusyRooms(rooms);

        }

        private static void showBusyRooms(Room[] rooms)
        {
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
                }

            }
        }
        private static void fillRooms(int roomsRented, Room[] rooms)
        {
            for (int i = 0; i < roomsRented; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Type your name: ");
                string nameInput = Console.ReadLine();

                Console.Write("Type your email: ");
                string emailInput = Console.ReadLine();
                int roomInput;
                do
                {
                    Console.Write("Choose a room: ");
                    string roomInput_ = Console.ReadLine();

                    if (int.TryParse(roomInput_, out int result))
                    {
                        roomInput = result;
                        break;
                    }
                } while (true);

                rooms[roomInput] = new Room
                {
                    Name = nameInput,
                    Email = emailInput
                };

            }
        }
    }
}
