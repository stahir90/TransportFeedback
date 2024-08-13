# Public Transport Feedback System

## Project Overview

The Public Transport Feedback System is a Minimal Viable Product (MVP) API designed to allow passengers to submit feedback about their travel experiences on various modes of public transport, including buses, trains, and ferries. Administrators can view, manage, and categorize this feedback, ensuring that passengers' concerns and suggestions are addressed effectively.

![Screenshot 2024-08-13 at 11 28 17 PM](https://github.com/user-attachments/assets/58cae338-75c2-40a1-866b-5047aa0d7a5f)


## Core Features

### User Feedback Submission

- Passengers can submit feedback about their travel experience.
- Feedback includes details such as:
  - Type of transport (bus, train, ferry)
  - Route number
  - Date and time of travel
  - The feedback itself (e.g., complaints, suggestions, or compliments)
- Passengers can optionally provide their contact details for follow-up.

### Admin Feedback Management

- Administrators can:
  - View all feedback
  - Categorize feedback
  - Mark feedback as resolved
  - Delete irrelevant feedback

### Authentication

- Basic authentication for admin users to access the feedback management portal.
- Public access to feedback submission without requiring authentication.

## Tech Stack

- **Backend:** ASP.NET Core 6.0
- **Database:** PostgreSQL
- **Authentication:** JWT (JSON Web Tokens) for admin authentication
- **ORM:** Entity Framework Core

## Step-by-Step Implementation

### 1. Project Setup

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/stahir90/public-transport-feedback-system.git


   ```
