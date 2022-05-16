using BusinessLayer.Conrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSon.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm = new CommentManager();
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            //CommentManager cm = new CommentManager();
            var commentList = cm.CommentByBlog(id);
            return PartialView(commentList);
        }
        [AllowAnonymous] 
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.Id = id;
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            //CommentManager cm = new CommentManager();
            c.CommentStatus = true;
            cm.CommentAdd(c);
            return PartialView();
        }
       
        public ActionResult AdminCommentListTrue()
        {
            var commentlist=cm.CommnetByStatusTrue();
            return View(commentlist);
        }
        public ActionResult AdminCommentListFalse()
        {
            var commentlist = cm.CommnetByStatusFalse();
            return View(commentlist);
        }
        public ActionResult StatusChangeToFalse(int id)
        {
            cm.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult StatusChangeToTrue(int id)
        {
            cm.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }
    }
}