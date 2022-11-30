using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.PersonHandlers
{
    public class DeletePersonHandler
    {
        private readonly Context _context;

        public DeletePersonHandler(Context context)
        {
            _context = context;
        }

        public void Handle(int id)
        {
            var person = _context.Persons.Find(id);

            _context.Remove(person);
            _context.SaveChanges
                ();
        }
    }
}
