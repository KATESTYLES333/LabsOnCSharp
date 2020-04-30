using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KursachServer.Services;
using KursachServer.Models.DBModels;

namespace KursachServer.Controllers
{
	[Route("api/[controller]")]
	public class ServiceController : Controller
	{
		private readonly ServicesService service;
		public ServiceController(ServicesService service)
		{
			this.service = service;
		}

		[HttpGet("get")]
		[HttpGet("get/{id}")]
		public Service GetService(int id)
		{
			return service.GetService(id);
		}

		[HttpGet("getAll")]
		public List<Service> GetAllServices()
		{
			return service.GetAllServices();
		}
	}
}