using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;

namespace AgentEase.Core.Models;

public class AgentEaseOptions
{
    public required string Model { get; init; }
    public string? Instructions { get; init; }    
    public int? MaxOutputTokens { get; init; }
    public float? Temperature { get; init; }        
    public IReadOnlyList<AITool>? Tools { get; init; }
    public IReadOnlyList<AIContextProvider>? AIContextProviders { get; init; }    
}

