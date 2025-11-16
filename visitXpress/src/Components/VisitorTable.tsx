import { type Visitor } from "../Pages/VisitorList";
import { FiEye, FiLogOut, FiPrinter } from "react-icons/fi";

interface Props {
  visitors: Visitor[];
  search: string;
  filterPerson: string;
  filterReason: string;
}

export function VisitorTable({
  visitors,
  search,
  filterPerson,
  filterReason,
}: Props) {
  const filtered = visitors.filter((v) => {
    return (
      (v.visitorName.toLowerCase().includes(search.toLowerCase()) ||
        v.visitorId.toLowerCase().includes(search.toLowerCase())) &&
      (filterPerson ? v.personToMeet === filterPerson : true) &&
      (filterReason
        ? v.reason.toLowerCase().includes(filterReason.toLowerCase())
        : true)
    );
  });

  return (
    <div className="table-container">
      <table className="visitor-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Visitor Name</th>
            <th>Email</th>
            <th>Person to Meet</th>
            <th>Reason</th>
            <th>In Time</th>
            <th>Actions</th>
          </tr>
        </thead>

        <tbody>
          {filtered.map((v) => (
            <tr key={v.visitorId}>
              <td>{v.visitorId}</td>
              <td className="truncate" title={v.visitorName}>
                {v.visitorName}
              </td>
              <td className="truncate" title={v.email}>
                {v.email}
              </td>
              <td>{v.personToMeet}</td>
              <td className="truncate" title={v.reason}>
                {v.reason}
              </td>
              <td>{v.inTime}</td>

              <td className="actions">
                <FiPrinter title="Generate QR" className="action-icon" />
                <FiLogOut title="Mark Exit" className="action-icon" />
                <FiEye title="View Details" className="action-icon" />
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
