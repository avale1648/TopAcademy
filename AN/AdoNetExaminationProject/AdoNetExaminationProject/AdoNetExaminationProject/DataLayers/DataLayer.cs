using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetExaminationProject.Models;
using AdoNetExaminationProject.Forms;
using static AdoNetExaminationProject.DataLayers.DataLayer;
using AdoNetExaminationProject.DataLayers.Forms;

namespace AdoNetExaminationProject.DataLayers
{
    public enum CurrentTable { Customers, Events, Tickets, Archive }
    public static class DataLayer
    {
        public static class AgeLimit
        {
            public static AgeLimitModel ById(int id)
            {
                using (var PosterDatabase = new PosterNewEntities())
                {
                    AgeLimitModel ageLimit = new AgeLimitModel();
                    var res = PosterDatabase.SelectAgeLimit(id).First();
                    ageLimit.Id = res.Id;
                    ageLimit.Age = res.Age;
                    return ageLimit;
                }
            }
            public static IEnumerable<AgeLimitModel> All()
            {
                using (var PosterDatabase = new PosterNewEntities())
                {
                    List<AgeLimitModel> ageLimits = new List<AgeLimitModel>();
                    var res = PosterDatabase.SelectAgeLimit(0).ToList();
                    foreach (var item in res)
                    {
                        AgeLimitModel ageLimit = new AgeLimitModel();
                        ageLimit.Id = item.Id;
                        ageLimit.Age = item.Age;
                        ageLimits.Add(ageLimit);
                    }
                    return ageLimits;
                }
            }
        }
        public static class Archive
        {
            public static ArchiveModel ById(int id)
            {
                using (var PosterDatabase = new PosterNewEntities())
                {
                    ArchiveModel inArchive = new ArchiveModel();
                    var res = PosterDatabase.SelectFromArchive(id).First();
                    inArchive.Id = res.Id;
                    inArchive.Name_ = res.Name_;
                    inArchive.DateTime_ = res.DateTime_;
                    inArchive.Country = res.Country;
                    inArchive.City = res.City;
                    inArchive.Adress = res.Adress;
                    inArchive.EventTypeId = res.EventTypeId;
                    inArchive.Name_1 = res.Name_1;
                    inArchive.Description_ = res.Description_;
                    inArchive.AgeLimitId = res.AgeLimitId;
                    inArchive.Age = res.Age;
                    inArchive.Tickets = res.Tickets;
                    inArchive.SoldTickets = res.SoldTickets;
                    return inArchive;
                }
            }
            public static IEnumerable<ArchiveModel> All()
            {
                using (var PosterDatabase = new PosterNewEntities())
                {
                    List<ArchiveModel> lotInArchive = new List<ArchiveModel>();
                    var res = PosterDatabase.SelectFromArchive(0).ToList();
                    foreach (var item in res)
                    {
                        ArchiveModel inArchive = new ArchiveModel();
                        inArchive.Id = item.Id;
                        inArchive.Name_ = item.Name_;
                        inArchive.DateTime_ = item.DateTime_;
                        inArchive.Country = item.Country;
                        inArchive.City = item.City;
                        inArchive.Adress = item.Adress;
                        inArchive.EventTypeId = item.EventTypeId;
                        inArchive.Name_1 = item.Name_1;
                        inArchive.Description_ = item.Description_;
                        inArchive.AgeLimitId = item.AgeLimitId;
                        inArchive.Age = item.Age;
                        inArchive.Tickets = item.Tickets;
                        inArchive.SoldTickets = item.SoldTickets;
                        lotInArchive.Add(inArchive);
                    }
                    return lotInArchive;
                }
            }

        }
        public static class Customer
        {
            public static CustomerModel ById(int id)
            {
                using (var PosterDatabase = new PosterNewEntities())
                {
                    CustomerModel customer = new CustomerModel();
                    var res = PosterDatabase.SelectCustomer(id).First();
                    customer.Id = res.Id;
                    customer.Name_ = res.Name_;
                    customer.Surname = res.Surname;
                    customer.Birthdate = res.Birthdate;
                    customer.TicketId = res.TicketId;
                    customer.Name_1 = res.Name_1;
                    return customer;
                }
            }
            public static IEnumerable<CustomerModel> All()
            {
                using (var PosterDatabase = new PosterNewEntities())
                {
                    List<CustomerModel> customers = new List<CustomerModel>();
                    var res = PosterDatabase.SelectCustomer(0).ToList();
                    foreach (var item in res)
                    {
                        CustomerModel customer = new CustomerModel();
                        customer.Id = item.Id;
                        customer.Name_ = item.Name_;
                        customer.Surname = item.Surname;
                        customer.Birthdate = item.Birthdate;
                        customer.TicketId = item.TicketId;
                        customer.Name_1 = item.Name_1;
                        customers.Add(customer);
                    }
                    return customers;
                }
            }
            public static int Add(CustomerModel customer)
            {
                using (var PosterDatabase = new PosterNewEntities())
                {
                    ObjectParameter addedCustomerId = new ObjectParameter("customerId", 0);
                    var res = PosterDatabase.InsertCustomer(name: customer.Name_, surname: customer.Surname,
                    birthdate: customer.Birthdate, ticketId: customer.TicketId, customerId: addedCustomerId);
                    return (int)addedCustomerId.Value;
                }
            }
            public static void Update(int id, CustomerModel customer)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    PosterDataBase.UpdateCustomer(id, name: customer.Name_, surname: customer.Surname,
                    birthdate: customer.Birthdate, ticketId: customer.TicketId);
                }
            }
            public static void Delete(int id)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    PosterDataBase.DeleteCustomer(id);
                }
            }
        }
        public static class Event
        {
            public static EventModel ById(int id)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    EventModel @event = new EventModel();
                    var res = PosterDataBase.SelectEvent(id).First();
                    @event.Id = res.Id;
                    @event.Name_ = res.Name_;
                    @event.DateTime_ = res.DateTime_;
                    @event.Country = res.Country;
                    @event.City = res.City;
                    @event.Adress = res.Adress;
                    @event.EventTypeId = res.EventTypeId;
                    @event.Name_1 = res.Name_1;
                    @event.Description_ = res.Description_;
                    @event.AgeLimitId = res.AgeLimitId;
                    @event.Age = res.Age;
                    @event.Tickets = res.Tickets;
                    @event.SoldTickets = res.SoldTickets;
                    return @event;
                }
            }
            public static IEnumerable<EventModel> All()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<EventModel> events = new List<EventModel>();
                    var res = PosterDataBase.SelectEvent(0).ToList();
                    foreach (var item in res)
                    {
                        EventModel @event = new EventModel();
                        @event.Id = item.Id;
                        @event.Name_ = item.Name_;
                        @event.DateTime_ = item.DateTime_;
                        @event.Country = item.Country;
                        @event.City = item.City;
                        @event.Adress = item.Adress;
                        @event.EventTypeId = item.EventTypeId;
                        @event.Name_1 = item.Name_1;
                        @event.Description_ = item.Description_;
                        @event.AgeLimitId = item.AgeLimitId;
                        @event.Age = item.Age;
                        @event.Tickets = item.Tickets;
                        @event.SoldTickets = item.SoldTickets;
                        events.Add(@event);
                    }
                    return events;
                }
            }
            public static int Add(EventModel @event)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    ObjectParameter addedEventId = new ObjectParameter("eventId", 0);
                    PosterDataBase.InsertEvent(name: @event.Name_, dateTime: @event.DateTime_, country: @event.Country,
                    city: @event.City, adress: @event.Adress, eventTypeId: @event.EventTypeId, description: @event.Description_,
                    ageLimitId: @event.AgeLimitId, tickets: @event.Tickets, soldTickets: @event.SoldTickets, eventId: addedEventId);
                    return (int)addedEventId.Value;
                }
            }
            public static void Update(int id, EventModel @event)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    PosterDataBase.UpdateEvent(eventId: id, name: @event.Name_, dateTime: @event.DateTime_,
                        country: @event.Country, city: @event.City, adress: @event.Adress, eventTypeId: @event.EventTypeId,
                        description: @event.Description_, ageLimitId: @event.AgeLimitId, tickets: @event.Tickets,
                        soldTickets: @event.SoldTickets);
                }
            }
            public static void Delete(int id)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    PosterDataBase.DeleteEvent(eventId: id);
                }
            }
        }
        public static class EventType
        {
            public static EventTypeModel ById(int id)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    EventTypeModel eventType = new EventTypeModel();
                    var res = PosterDataBase.SelectEventType(id).First();
                    eventType.Id = res.Id;
                    eventType.Name_ = res.Name_;
                    return eventType;
                }
            }
            public static IEnumerable<EventTypeModel> All()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<EventTypeModel> eventTypes = new List<EventTypeModel>();
                    var res = PosterDataBase.SelectEventType(0).ToList();
                    foreach (var item in res)
                    {
                        EventTypeModel eventType = new EventTypeModel();
                        eventType.Id = item.Id;
                        eventType.Name_ = item.Name_;
                        eventTypes.Add(eventType);
                    }
                    return eventTypes;
                }
            }
        }
        public static class Ticket
        {
            public static TicketModel ById(int id)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    TicketModel ticket = new TicketModel();
                    var res = PosterDataBase.SelectTicket(id).First();
                    ticket.Id = res.Id;
                    ticket.EventId = res.EventId;
                    ticket.Name_ = res.Name_;
                    ticket.Price = res.Price;
                    return ticket;
                }
            }
            public static IEnumerable<TicketModel> All()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<TicketModel> tickets = new List<TicketModel>();
                    var res = PosterDataBase.SelectTicket(0).ToList();
                    foreach (var item in res)
                    {
                        TicketModel ticket = new TicketModel();
                        ticket.Id = item.Id;
                        ticket.EventId = item.EventId;
                        ticket.Name_ = item.Name_;
                        ticket.Price = item.Price;
                        tickets.Add(ticket);
                    }
                    return tickets;
                }
            }
            public static int Add(TicketModel ticket)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    ObjectParameter addedTicketId = new ObjectParameter("ticketId", 0);
                    var res = PosterDataBase.InsertTicket(eventId: ticket.EventId, price: ticket.Price, ticketId: addedTicketId);
                    return (int)addedTicketId.Value;
                }
            }
            public static void Update(int id, TicketModel ticket)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    PosterDataBase.UpdateTicket(ticketId: id, eventId: ticket.EventId, price: ticket.Price);
                }
            }
            public static void Delete(int id)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    PosterDataBase.DeleteTicket(id);
                }
            }
        }
        public static class ListView
        {
            private static void FromArchive(System.Windows.Forms.ListView listView)
            {
                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.Add("Ид", 50);
                listView.Columns.Add("Название", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Дата и время", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Страна", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Город", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Адрес", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Категория", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Описание", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Возрастное ограничение", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Билеты", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Купленные билеты", (int)((listView.Size.Width - 50) / 10));
                IEnumerable<ArchiveModel> archive = DataLayer.Archive.All();
                foreach (var item in archive)
                {
                    string[] strings = new string[]
                    {
                        item.Id.ToString(),
                        item.Name_,
                        item.DateTime_.ToString(),
                        item.Country,
                        item.City,
                        item.Adress,
                        item.EventTypeId.ToString() + " ==> " + item.Name_1,
                        item.Description_,
                        item.AgeLimitId.ToString() + " ==> " + item.Age.ToString() + "+",
                        item.Tickets.ToString(),
                        item.SoldTickets.ToString()
                    };
                    listView.Items.Add(new ListViewItem(strings));
                }
            }
            private static void FromCustomers(System.Windows.Forms.ListView listView)
            {
                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.Add("Ид", 50);
                listView.Columns.Add("Фамилия", (int)((listView.Size.Width - 50) / 4));
                listView.Columns.Add("Имя", (int)((listView.Size.Width - 50) / 4));
                listView.Columns.Add("Дата рождения", (int)((listView.Size.Width - 50) / 4));
                listView.Columns.Add("Билет", (int)((listView.Size.Width - 50) / 4));
                IEnumerable<CustomerModel> customers = DataLayer.Customer.All();
                foreach (var item in customers)
                {
                    string[] strings = new string[]
                    {
                        item.Id.ToString(),
                        item.Surname,
                        item.Name_,
                        item.Birthdate.ToString(),
                        item.TicketId.ToString() + " ==> " + item.Name_1
                    };
                    listView.Items.Add(new ListViewItem(strings));
                }
            }
            private static void FromEvents(System.Windows.Forms.ListView listView)
            {
                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.Add("Ид", 50);
                listView.Columns.Add("Название", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Дата и время", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Страна", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Город", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Адрес", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Категория", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Описание", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Возрастное ограничение", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Билеты", (int)((listView.Size.Width - 50) / 10));
                listView.Columns.Add("Купленные билеты", (int)((listView.Size.Width - 50) / 10));
                IEnumerable<EventModel> archive = DataLayer.Event.All();
                foreach (var item in archive)
                {
                    string[] strings = new string[]
                    {
                        item.Id.ToString(),
                        item.Name_,
                        item.DateTime_.ToString(),
                        item.Country,
                        item.City,
                        item.Adress,
                        item.EventTypeId.ToString() + " ==> " + item.Name_1,
                        item.Description_,
                        item.AgeLimitId.ToString() + " ==> " + item.Age.ToString() + "+",
                        item.Tickets.ToString(),
                        item.SoldTickets.ToString()
                    };
                    listView.Items.Add(new ListViewItem(strings));
                }
            }
            private static void FromTickets(System.Windows.Forms.ListView listView)
            {
                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.Add("Ид", 50);
                listView.Columns.Add("Событие", (int)((listView.Size.Width - 50) / 2));
                listView.Columns.Add("Цена, руб.", (int)((listView.Size.Width - 50) / 2));
                IEnumerable<TicketModel> tickets = DataLayer.Ticket.All();
                foreach (var item in tickets)
                {
                    string[] strings = new string[]
                    {
                        item.Id.ToString(),
                        item.EventId.ToString() + " ==> " + item.Name_,
                        item.Price.ToString()
                    };
                    listView.Items.Add(new ListViewItem(strings));
                }
            }
            public static void Fill(CurrentTable currentTable, System.Windows.Forms.ListView listView)
            {
                switch(currentTable)
                {
                    case CurrentTable.Archive:
                        DataLayer.ListView.FromArchive(listView); 
                        break;
                    case CurrentTable.Customers:
                        DataLayer.ListView.FromCustomers(listView);
                        break;
                    case CurrentTable.Events:
                        DataLayer.ListView.FromEvents(listView);
                        break;
                    case CurrentTable.Tickets:
                        DataLayer.ListView.FromTickets(listView);
                        break;
                }
            }
        }
        public static class Form
        {
            public static void Add(CurrentTable currentTable)
            {
                int id = 0;
                try
                {
                    switch (currentTable)
                    {
                        case CurrentTable.Customers:
                            {
                                CustomerForm customerForm = new CustomerForm();
                                customerForm.Text = "Добавить клиента";
                                customerForm.ShowDialog();
                                if (customerForm.DialogueResult == DialogResult.OK)
                                    id = DataLayer.Customer.Add(customerForm.Customer);
                                if (id != 0)
                                    MessageBox.Show($"Новый клиент был добавлен. Идентификатор: {id}", "Новый клиент", MessageBoxButtons.OK);
                                break;
                            }
                        case CurrentTable.Events:
                            {
                                EventForm eventForm = new EventForm();
                                eventForm.Text = "Добавить событие";
                                eventForm.ShowDialog();
                                if (eventForm.DialogueResult == DialogResult.OK)
                                    id = DataLayer.Event.Add(eventForm.Event);
                                if (id != 0)
                                    MessageBox.Show($"Новое событие было добавлено. Идентификатор: {id}", "Новое событие", MessageBoxButtons.OK);
                                break;
                            }
                        case CurrentTable.Tickets:
                            {
                                TicketForm ticketForm = new TicketForm();
                                ticketForm.Text = "Добавить билет";
                                ticketForm.ShowDialog();
                                if (ticketForm.DialogueResult == DialogResult.OK)
                                    id = DataLayer.Ticket.Add(ticketForm.Ticket);
                                if (id != 0)
                                    MessageBox.Show($"Новый билет был добавлен. Идентификатор: {id}", "Новый билет", MessageBoxButtons.OK);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            public static void Update(int id, CurrentTable currentTable)
            {
                try
                {
                    switch (currentTable)
                    {
                        case CurrentTable.Customers:
                            {
                                CustomerForm customerForm = new CustomerForm();
                                customerForm.Text = "Изменить клиента";
                                customerForm.ShowDialog();
                                if (customerForm.DialogueResult == DialogResult.OK)
                                {
                                    DataLayer.Customer.Update(id, customerForm.Customer);
                                    MessageBox.Show($"Клиент был изменен. Идентификатор: {id}", "Измененный клиент", MessageBoxButtons.OK);
                                }
                                break;
                            }
                        case CurrentTable.Events:
                            {
                                EventForm eventForm = new EventForm();
                                eventForm.Text = "Изменить клиента";
                                eventForm.ShowDialog();
                                if (eventForm.DialogueResult == DialogResult.OK)
                                {
                                    DataLayer.Event.Update(id, eventForm.Event);
                                    MessageBox.Show($"Событие было изменено. Идентификатор: {id}", "Измененное событие", MessageBoxButtons.OK);
                                }
                                break;
                            }
                        case CurrentTable.Tickets:
                            {
                                TicketForm ticketForm = new TicketForm();
                                ticketForm.Text = "Изменить билет";
                                ticketForm.ShowDialog();
                                if (ticketForm.DialogueResult == DialogResult.OK)
                                {
                                    DataLayer.Ticket.Update(id, ticketForm.Ticket);
                                    MessageBox.Show($"Клиент был изменен. Идентификатор: {id}", "Измененный клиент", MessageBoxButtons.OK);
                                }
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            public static void Delete(int id, CurrentTable currentTable)
            {
                try
                {
                    switch (currentTable)
                    {
                        case CurrentTable.Customers:
                            {
                                DataLayer.Customer.Delete(id);
                                break;
                            }
                        case CurrentTable.Events:
                            {
                                DataLayer.Event.Delete(id);
                                break;
                            }
                        case CurrentTable.Tickets:
                            {
                                DataLayer.Ticket.Delete(id);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Исключение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            public static void SaleTicket()
            {
                SaleTicketForm saleTicketForm = new SaleTicketForm();
                if (saleTicketForm.ShowDialog() == DialogResult.OK)
                    MessageBox.Show(DataLayer.Procedures.SaleTicket(saleTicketForm.EventId, saleTicketForm.CustomerId));
            }
        }
        public static class Procedures
        {
            public static List<string> First(DateTime datetime)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure1(datetime).ToList();
                    foreach (var item in res) 
                        result.Add(item);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Second(int id)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure2(id).ToList();
                    foreach (var item in res)
                        result.Add(item);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Third()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure3().ToList();
                    foreach (var item in res) 
                        result.Add(item.Name_);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Fourth()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure4().ToList();
                    foreach (var item in res) 
                        result.Add(item.Name_);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Fifth()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure5().ToList();
                    foreach (var item in res) 
                        result.Add(item);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Sixth(string city)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure6(city).ToList();
                    foreach (var item in res)
                        result.Add(item.Name_);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Eigth()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure8().ToList();
                    foreach (var item in res)
                        result.Add(item);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Ninth(DateTime dateTime)
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure9(dateTime, new DateTime(dateTime.Year, dateTime.Month, dateTime.Day + 5)).ToList();
                    foreach (var item in res) 
                        result.Add(item.Name_);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Tenth()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure10(DateTime.Now).ToList();
                    foreach (var item in res)
                        result.Add(item.Name_);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static List<string> Eleventh()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.Procedure11(DateTime.Now).ToList();
                    foreach (var item in res) 
                        result.Add(item);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
            public static string SaleTicket(int eventId, int customerId)
            {
                List<EventModel> events = (List<EventModel>)DataLayer.Event.All();
                List<CustomerModel> customers = (List<CustomerModel>)DataLayer.Customer.All();
                EventModel @event = events.Find(x => x.Id == eventId);
                CustomerModel customer = customers.Find(x => x.Id == customerId);
                using (var PosterDataBase = new PosterNewEntities())
                {
                    PosterDataBase.SaleTicket(eventId, customerId);
                    return $"{customer.Surname} {customer.Name_} купил(а) билет на {@event.Name_1} {@event.Name_}";
                }
            }
        }
        public static class Views
        {
            public static List<string> First()
            {
                using (var PosterDataBase = new PosterNewEntities())
                {
                    List<string> result = new List<string>();
                    var res = PosterDataBase.View1.ToList();
                    foreach (var item in res)
                        result.Add(item.Customer + " " + item.Birthdate + " " + item.Tickets_Sold);
                    if (result.Count == 0)
                        result.Add("Нет событий");
                    return result;
                }
            }
        }
    }
}

