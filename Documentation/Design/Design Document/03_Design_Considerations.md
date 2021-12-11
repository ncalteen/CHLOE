# Design Considerations

## Authentication

To interact with actual resources within an AWS account, users will need to configure appropriate AWS credentials (AWS CLI profile or federated identity). This will be exposed to the user as an initial entry splash screen, and saved to the user's save data. To protect AWS credentials, players will not be able to log in with a root user, or enter access key ID/secret access key information directly into the application.

## Metrics

The following metrics will be tracked to measure success of CHLOE.

- Usage
  - New user downloads
  - Daily active users
  - Monthly active users
  - Average sessions per daily active user
  - Retention (1-, 3-, 7-, 30-day measure)
  - Churn (28-day measure)
- Level progression (per level, per player)
  - Start count
  - Failure count
  - Completion count
  - Completion time
  - "Beat" duration (time to reach critical level stages)
- Simulation usage
  - Simulation mode session time
  - AWS resource usage in simulation mode
- Feedback
  - In-game feedback submission rate
  - In-game feedback submission score
  - Bug report submissions
  - Feature request submissions

## SLA and Alarms

The following SLAs will be adhered to:

- Feature parity of supported AWS services by CHLOE will be maintained within a 120-day time frame. Support will be communicated to users as release notes during patches.
  - This SLA will be applied after the v1.0.0 release of the client.

## Support

The code base for CHLOE will be made available via GitHub.
