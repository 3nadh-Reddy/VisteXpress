import { useState } from "react";
import { VisitorFilters } from "../Components/VisitorFilters";
import { VisitorTable } from "../Components/VisitorTable";
import "../Styles/VisitorList.css";

export interface Visitor {
  visitorId: string;
  visitorName: string;
  email: string;
  personToMeet: string;
  reason: string;
  inTime: string;
}

export function VisitorList() {
  const [search, setSearch] = useState("");
  const [filterPerson, setFilterPerson] = useState("");
  const [filterReason, setFilterReason] = useState("");

  // Dummy Data - replace with API results
  const visitors: Visitor[] = [
    {
      visitorId: "V1001",
      visitorName: "Rahul Sharma",
      email: "rahul.sharma@example.com",
      personToMeet: "Manager",
      reason: "Interview for Software Engineer position",
      inTime: "10:45 AM",
    },
    {
      visitorId: "V1002",
      visitorName: "Sneha Reddy",
      email: "sneha.reddy@example.com",
      personToMeet: "HR",
      reason: "Document submission",
      inTime: "11:30 AM",
    },
  ];

  return (
    <div className="visitor-list-wrapper">
      <h1>Visitor List</h1>

      <VisitorFilters
        search={search}
        setSearch={setSearch}
        filterPerson={filterPerson}
        setFilterPerson={setFilterPerson}
        filterReason={filterReason}
        setFilterReason={setFilterReason}
      />

      <VisitorTable
        visitors={visitors}
        search={search}
        filterPerson={filterPerson}
        filterReason={filterReason}
      />
    </div>
  );
}
