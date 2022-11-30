using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using System.Xml.Linq;
using System;
using System.Linq;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.PersonHandlers
{
    public class UpdatePersonHandler
    {
        private readonly Context _context;

        public UpdatePersonHandler(Context context)
        {
            _context = context;
        }


        public void Handle(UpdatePersonCommand command)
        {
            var person = _context.Persons.Find(command.PersonID);

            person.City = command.City;
            person.Name = command.Name;
            person.Surname = command.Surname;
            person.Mail = command.Mail;
            person.Department = command.Departman;
            person.Phone = command.Phone;

            _context.SaveChanges();
        }

        public UpdatePersonCommand Find(int id)
        {

            var person = _context.Persons.
                  Where(x => x.PersonID == id)
                  .Select(x => new { x.Name, x.Surname, x.Mail, x.Phone, x.Department, x.City }
                  ).First();

            UpdatePersonCommand command = new UpdatePersonCommand();
            command.PersonID = id;
            command.City = person.City;
            command.Name = person.Name;
            command.Surname = person.Surname;
            command.Mail = person.Mail;
            command.Departman = person.Department;
            command.Phone = person.Phone;

            return command;
        }
    }
}

