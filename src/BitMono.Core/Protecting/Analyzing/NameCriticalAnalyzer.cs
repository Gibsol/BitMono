﻿namespace BitMono.Core.Protecting.Analyzing;

public class NameCriticalAnalyzer :
    ICriticalAnalyzer<TypeDefinition>,
    ICriticalAnalyzer<MethodDefinition>
{
    private readonly CriticalInterfacesCriticalAnalyzer m_CriticalInterfacesCriticalAnalyzer;
    private readonly CriticalBaseTypesCriticalAnalyzer m_CriticalBaseTypesCriticalAnalyzer;
    private readonly CriticalMethodsCriticalAnalyzer m_CriticalMethodsCriticalAnalyzer;

    public NameCriticalAnalyzer(
        CriticalInterfacesCriticalAnalyzer criticalInterfacesCriticalAnalyzer,
        CriticalBaseTypesCriticalAnalyzer criticalBaseTypesCriticalAnalyzer,
        CriticalMethodsCriticalAnalyzer criticalMethodsCriticalAnalyzer)
    {
        m_CriticalInterfacesCriticalAnalyzer = criticalInterfacesCriticalAnalyzer;
        m_CriticalBaseTypesCriticalAnalyzer = criticalBaseTypesCriticalAnalyzer;
        m_CriticalMethodsCriticalAnalyzer = criticalMethodsCriticalAnalyzer;
    }

    public bool NotCriticalToMakeChanges(TypeDefinition type)
    {
        if (m_CriticalInterfacesCriticalAnalyzer.NotCriticalToMakeChanges(type) == false)
        {
            Console.WriteLine("-----------------------------------------------------> CRITICAL TO RENAME TYPE... SAD");
            return false;
        }
        if (m_CriticalBaseTypesCriticalAnalyzer.NotCriticalToMakeChanges(type) == false)
        {
            Console.WriteLine("-----------------------------------------------------> CRITICAL TO RENAME BASE TYPE... SAD");
            return false;
        }
        return true;
    }
    public bool NotCriticalToMakeChanges(MethodDefinition method)
    {
        return m_CriticalMethodsCriticalAnalyzer.NotCriticalToMakeChanges(method);
    }
}