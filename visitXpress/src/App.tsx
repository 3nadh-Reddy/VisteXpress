import { useState } from "react";
import { Routes, Route } from "react-router-dom";
import { Sidebar } from "./Components/Sidebar";
import { Topbar } from "./Components/Topbar";
import { AddVisitor } from "./Pages/AddVisitor";
import { VisitorList } from "./Pages/VisitorList";
import "./Styles/App.css";

function App() {
  const [isOpen, setIsOpen] = useState(false);

  return (
    <div className="app-layout">
      <Sidebar isOpen={isOpen} setIsOpen={setIsOpen} />
      <div className="main">
        <Topbar />

        <div className="content">
          <Routes>
            <Route path="/" element={<VisitorList />} />
            <Route path="/add-visitor" element={<AddVisitor />} />
          </Routes>
        </div>
      </div>
    </div>
  );
}

export default App;
