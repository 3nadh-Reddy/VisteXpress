import { Link } from "react-router-dom";
import { FiUserPlus, FiList, FiMenu } from "react-icons/fi";

export interface SidebarProps {
  isOpen: boolean;
  setIsOpen: React.Dispatch<React.SetStateAction<boolean>>;
}

export function Sidebar({ isOpen, setIsOpen }: SidebarProps) {
  return (
    <div className={`sidebar ${isOpen ? "open" : "closed"}`}>
      <div className="toggle-container">
        <FiMenu className="toggle-btn" onClick={() => setIsOpen(!isOpen)} />
      </div>

      {isOpen && <h3 className="logo">VisitorMS</h3>}

      <ul>
        <li>
          <Link to="/">
            <FiList className="sidebar-icon" />
            <span className="sidebar-text">Visitor List</span>
          </Link>
        </li>

        <li>
          <Link to="/add-visitor">
            <FiUserPlus className="sidebar-icon" />
            <span className="sidebar-text">Add Visitor</span>
          </Link>
        </li>
      </ul>
    </div>
  );
}
