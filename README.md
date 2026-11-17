# Blood Bank Appointment Management System

A C# and SQL application that allows blood donors to book, view and manage their donation appointments, while giving admin staff full control over donor records and appointment schedules.

Built to replace manual paper-based booking with a structured, reliable system that keeps donor information and appointment data consistent.

**Duration:** Jun 2025 — Oct 2025  
**Tech Stack:** C# | SQL | Windows Forms / WPF | Visual Studio

---

## Problem It Solves

Blood banks often rely on phone calls and paper registers to schedule donations. This leads to double bookings, missed appointments and lost donor records.
This system centralises everything in one place — donors can self-manage their bookings, and staff can quickly find donors, check schedules and manage appointments.

## Features

### For Donors
- Register as a donor with personal details and blood group
- Book a donation appointment by date and time
- View upcoming and past appointments
- Reschedule or cancel an appointment
- View donation history

### For Admin / Staff
- Add, edit and search donor records
- View all appointments by date, donor or blood group
- Approve / confirm / cancel appointments
- Manage appointment slots and availability
- Search donors by blood group for urgent needs

### System Features
- Input validation to prevent invalid dates, duplicate bookings and missing fields
- Relational database to link donors, appointments and blood groups correctly
- Clean, easy-to-use interface for both donors and staff

## Database Design

Relational SQL database with tables for:

- **Donors** — DonorID, Full Name, ID Number, Contact, Blood Group, Last Donation Date
- **Appointments** — AppointmentID, DonorID (FK), Appointment Date, Time Slot, Status
- **Admins** — AdminID, Username, Password

Relationships enforced with foreign keys to maintain data integrity and prevent orphaned appointment records.

## Tech Used

- **Language:** C#
- **Database:** SQL Server
- **IDE:** Visual Studio
- **Design:** ERD, UML Class & Use Case Diagrams
- **Version Control:** Git & GitHub
