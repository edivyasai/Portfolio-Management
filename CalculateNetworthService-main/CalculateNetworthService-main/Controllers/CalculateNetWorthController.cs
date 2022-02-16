﻿using CalculateNetWorth.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculateNetWorth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateNetWorthController : ControllerBase
    {
        private static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CalculateNetWorthController));
        private readonly ICalculateNetWorth _obj;
        public CalculateNetWorthController(ICalculateNetWorth obj)
        {
            _obj = obj;

        }

        [HttpPost("GetStockByCustomer")]
        
        public async Task<ActionResult> GetStockByCustomerAsync(PortfolioDetail customer)
        {
            _log4net.Info("Http Post request GetStockByCustomer");
            if (customer == null)
            {
                return BadRequest();
            }
            return Ok(await _obj.GetStockTransactionDetails(customer));
        }

        [HttpPost("GetMutualFundByCustomer")]
        public async Task<ActionResult> GetMutualFundByCustomerAsync(PortfolioDetail customer)
        {
            _log4net.Info("Http Post request of GetMutualFundByCustomer");
            if (customer == null)
            {
                return BadRequest();
            }
            return Ok(await _obj.GetMutualFundTransactionDetails(customer));
        }

        [HttpPost]
        public async Task<ActionResult> calculateNetWorth([FromBody] PortfolioDetail customer)
        {
            _log4net.Info("Http Post request of calculateNetWorth");

            if (customer == null)
            {
                return BadRequest();
            }
            int netWorth = 0;
            var StockList = await _obj.GetStockTransactionDetails(customer);
            var MutualFundList = await _obj.GetMutualFundTransactionDetails(customer);

            foreach (var item in StockList)
            {
                netWorth += item.TotalPrice;
            }
            foreach (var item in MutualFundList)
            {
                netWorth += item.TotalPrice;
            }
            return Ok(netWorth);
        }

        [HttpGet("sellStock/{id}")]
        public ActionResult SellStock(int id)
        {
            _log4net.Info("Get Post request of SellStock");

            _obj.SellStock(id);
            return Ok();
        }

        [HttpGet("sellMutualFund/{id}")]
        public ActionResult SellMutualFund(int id)
        {
            _log4net.Info("Get Post request of SellMutualFund");

            _obj.SellMutualFund(id);
            return Ok();
        }
    }
}
