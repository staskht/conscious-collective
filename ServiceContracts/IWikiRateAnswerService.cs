using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContracts
{
    public interface IWikiRateAnswerService
    {
        /// <summary>
        /// Retreives an object using http request
        /// </summary>
        /// <param name="companyName">the company name to search by</param>
        /// <returns>eturns a dto object with class class members the fashion transparency index and the name of the company</returns>
        Task<WikiRateAnswerDto?> GetFashionTransparencyIndex(string companyName);
    }
}
