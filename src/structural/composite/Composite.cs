namespace DesignPatterns.Structural.Composite
{
    // Component interface
    public abstract class Component
    {
        public abstract void Operation();
    }

    // Leaf class
    public class Leaf : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Leaf operation");
        }
    }

    // Composite class
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public void Add(Component component)
        {
            _children.Add(component);
        }

        public void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Operation()
        {
            Console.WriteLine("Composite operation");
            foreach (var child in _children)
            {
                // Aquí llamamos a la implementación de Operation en los hijos
                child.Operation();
            }
        }
    }

    // Client code
    class Program
    {
        static void Main()
        {
            // Crear el composite principal (root)
            Composite root = new Composite();
            root.Add(new Leaf());

            // Crear una rama (branch) del composite
            Composite branch = new Composite();
            branch.Add(new Leaf());
            branch.Add(new Leaf());

            // Añadir la rama al composite principal
            root.Add(branch);

            // Llamar a la operación
            root.Operation();
        }
    }
}
