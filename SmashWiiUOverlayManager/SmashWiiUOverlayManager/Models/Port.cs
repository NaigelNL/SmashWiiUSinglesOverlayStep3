using System.Collections.ObjectModel;

namespace SmashWiiUOverlayManager.Models
{
    public class Port
    {
        private static int currentId = 1;

        public int Id { get; private set; }
        public string Name { get { return string.Format("Player {0}", Id.ToString()); } }
        public string Path { get { return string.Format(@"..\\playerPorts\\playerPort{0}.png", Id.ToString()); } }

        public Port()
        {
            Id = currentId;
            currentId++;
        }

        public static ObservableCollection<Port> InitiatePortList(int count)
        {
            var list = new ObservableCollection<Port>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Port());
            }
            return list;
        }
    }
}
