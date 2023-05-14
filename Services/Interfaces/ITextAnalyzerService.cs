using GRitiD.Models;
using Microsoft.AspNetCore.Mvc;

namespace GRitiD.Servces.Interfaces
{
    public interface ITextAnalyzerService
    {
        public Stats Analyze(string text);
    }
}
