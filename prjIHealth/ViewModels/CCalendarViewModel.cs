using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class CCalendarViewModel
    {
        public TReservation Reservation;
        public CCalendarViewModel(TReservation r)
        {
            Reservation = r;
        }
        public List<CCalendarViewModel> ReservationList(List<TReservation> reservations)
        {
            List<CCalendarViewModel> list = new List<CCalendarViewModel>();
            foreach(var r in reservations)
            {
                CCalendarViewModel vModel = new CCalendarViewModel(r);
                list.Add(vModel);
            }
            return list;
        }
        public int FReservationId
        {
            get { return Reservation.FReservationId; }
        }
        public int? FCourseId
        {
            get { return Reservation.FCourseId; }
        }
        public string FCourseTime
        {
            get { return Reservation.FCourseTime; }
            set { Reservation.FCourseTime = value; }
        }
        //上課日期
        public string CourseDate
        {
            get { return Reservation.FCourseTime.Substring(0,8); }
        }
        //上課時間
        public string CourseTime
        {
            get { return Reservation.FCourseTime.Substring(8, 4); }
        }
        public int? FStatusNumber
        {
            get { return Reservation.FStatusNumber; }
            set { Reservation.FStatusNumber = value; }
        }
        public string Status
        {
            get { return Reservation.FStatusNumber == 60 ? "未完成" : "已完成"; }
        }
    }
}
