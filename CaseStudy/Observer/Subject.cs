using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private FacadeModel _facadeModel = new FacadeModel();
        public void attach(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void sendNotify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void handleAction(int type)
        {
            switch(type)
            {
                case 1:
                    sendNotify($"{_facadeModel.CreateProduct()}");
                    break;
                case 2:
                    sendNotify($"{_facadeModel.CreateMember()}");
                    break;
                default:
                    sendNotify("No message");
                    break;
            }
            
        }
    }
}
