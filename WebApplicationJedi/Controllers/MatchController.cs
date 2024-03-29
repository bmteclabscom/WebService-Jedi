﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationJedi.Models;
using WebApplicationJedi.ServiceReference;

namespace WebApplicationJedi.Controllers {
	public class MatchController : Controller {
		// GET: Match
		public ActionResult Index() {
			List<MatchViewModel> list = new List<MatchViewModel>();

			using(ServiceReference.ServiceClient service = new ServiceReference.ServiceClient()) {
				foreach(var match in service.getMatches()) {
					list.Add(new MatchViewModel(match));
				}
			}

			return View(new MatchCollection(list));
		}

		// GET: Match/Details/5
		public ActionResult Details(int id) {
			return View();
		}

		// GET: Match/Create
		public ActionResult Create() {
			return View();
		}

		// POST: Match/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection) {
			try {
				// TODO: Add insert logic here

				return RedirectToAction("Index");
			} catch {
				return View();
			}
		}

		// GET: Match/Edit/5
		public ActionResult Edit(int id) {
			return View();
		}

		// POST: Match/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection) {
			try {
				// TODO: Add update logic here

				return RedirectToAction("Index");
			} catch {
				return View();
			}
		}

		// GET: Match/Delete/5
		public ActionResult Delete(int id) {
			return View();
		}

		// POST: Match/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection) {
			try {
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			} catch {
				return View();
			}
		}
	}
}
