using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class CCourseViewModel
    {
        public TCourse Course;
        public CCourseViewModel()
        {
            Course = new TCourse();
        }
        public CCourseViewModel(TCourse c)
        {
            Course = c;
        }
        static public List<CCourseViewModel> CourseList(List<TCourse> courseList)
        {
            List<CCourseViewModel> list = new List<CCourseViewModel>();
            foreach (var c in courseList)
            {
                CCourseViewModel vModel = new CCourseViewModel(c);
                list.Add(vModel);
            }
            return list;
        }
        public int FCourseId
        {
            get { return Course.FCourseId; }
        }
        public int? FCoachContactId
        {
            get { return Course.FCoachContactId; }
            set { Course.FCoachContactId = value; }
        }
        [DisplayName("會員編號")]
        public int? MemberId
        {
            get { return Course.FCoachContact.FMember.FMemberId; }
            set { Course.FCoachContact.FMember.FMemberId = (int)value; }
        }
        [DisplayName("會員姓名")]
        public string MemberName
        {
            get { return Course.FCoachContact.FMember.FMemberName; }
            set { Course.FCoachContact.FMember.FMemberName = value; }
        }
        [DisplayName("聯絡電話")]
        public string MemberPhone
        {
            get { return Course.FCoachContact.FMember.FPhone; }
            set { Course.FCoachContact.FMember.FPhone = value; }
        }
        [DisplayName("總堂數")]
        public int? FCourseTotal
        {
            get { return Course.FCourseTotal; }
            set { Course.FCourseTotal = value; }
        }
        [DisplayName("課程名稱")]
        public string FCourseName
        {
            get { return Course.FCourseName; }
            set { Course.FCourseName = value; }
        }
        [DisplayName("課程時間")]
        public int? FAvailableTimeNum
        {
            get { return Course.FAvailableTimeNum; }
            set { Course.FAvailableTimeNum = value; }
        }             
        public int? FStatusNumber
        {
            get { return Course.FStatusNumber; }
            set { Course.FStatusNumber = value; }
        }
        [DisplayName("課程狀態")]
        public string Status
        {
            get { return Course.FStatusNumber == 55 ? "進行中" : "已結束"; }
        }
        public bool? FVisible
        {
            get { return Course.FVisible; }
            set { Course.FVisible = value; }
        }       
    }
}
