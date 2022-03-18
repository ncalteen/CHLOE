using System.Collections.Generic;

public enum ServiceCategoryTypes
{
    ANALYTICS,
    APPLICATION_INTEGRATION,
    BLOCKCHAIN,
    CLOUD_FINANCIAL_MANAGEMENT,
    COMPUTE,
    CONTAINERS,
    DATABASE,
    DEVELOPER_TOOLS,
    END_USER_COMPUTING,
    FRONT_END_WEB_AND_MOBILE,
    INTERNET_OF_THINGS,
    MACHINE_LEARNING,
    MANAGEMENT_AND_GOVERNANCE,
    MEDIA_SERVICES,
    MIGRATION_AND_TRANSFER,
    NETWORKING_AND_CONTENT_DELIVERY,
    QUANTUM_TECHNOLOGIES,
    ROBOTICS,
    SATELLITE,
    SECURITY_IDENTITY_AND_COMPLIANCE,
    STORAGE,
    VR_AND_AR,
};

public static class ServiceCategory
{
    public static readonly List<string> ServiceCategoryNames = new List<string>
    {
        "Analytics",
        "Application Integration",
        "Blockchain",
        "Cloud Financial Management",
        "Compute",
        "Containers",
        "Database",
        "Developer Tools",
        "End User Computing",
        "Front-End Web & Mobile",
        "Internet of Things",
        "Machine Learning",
        "Management & Governance",
        "Media Services",
        "Migration & Transfer",
        "Networking & Content Delivery",
        "Quantum Technologies",
        "Robotics",
        "Satellite",
        "Security, Identity, & Compliance",
        "Storage",
        "VR & AR",
    };

    public static string Name(ServiceCategoryTypes type)
    {
        return ServiceCategoryNames[((int)type)];
    }
}
