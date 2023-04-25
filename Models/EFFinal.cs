using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EFFinal : IFinal
    {

        private EntertainmentAgencyExampleContext context { get; set; }

        public EFFinal (EntertainmentAgencyExampleContext temp)
        {
            context = temp;
        }
        public IQueryable<Entertainer> Entertainers => context.Entertainers;


        public void EditEntertainer (Entertainer entertainer)
        {

            var e = context.Entertainers.First(x => x.EntertainerId == entertainer.EntertainerId);

            if (e != null)
            {

                e.EntertainerId = entertainer.EntertainerId;
                e.EntStageName = entertainer.EntStageName;
                e.EntSsn = entertainer.EntSsn;
                e.EntStreetAddress = entertainer.EntStreetAddress;
                e.EntCity = entertainer.EntCity;
                e.EntState = entertainer.EntState;
                e.EntZipCode = entertainer.EntZipCode;
                e.EntPhoneNumber = entertainer.EntPhoneNumber;
                e.EntWebPage = entertainer.EntWebPage;
                e.EntEmailAddress = entertainer.EntEmailAddress;
                e.DateEntered = entertainer.DateEntered;

                context.Entry(e).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void CreateEntertainer(Entertainer entertainer)
        {

            double maxId = context.Entertainers.Max(b => b.EntertainerId);

            double nextId = maxId + 1;

            entertainer.EntertainerId = (long)nextId;

            context.Entertainers.Add(entertainer);
            context.SaveChanges();
        }

        public void DeleteEntertainer(double entertainerId)
        {
            long newId = (long)entertainerId;
            var entertainer = context.Entertainers.Find(newId);
            if (entertainer != null)
            {
                context.Entertainers.Remove(entertainer);
                context.SaveChanges();
            }
        }
    }
}
