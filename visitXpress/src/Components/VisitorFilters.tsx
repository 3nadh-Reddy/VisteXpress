interface Props {
  search: string;
  setSearch: (v: string) => void;
  filterPerson: string;
  setFilterPerson: (v: string) => void;
  filterReason: string;
  setFilterReason: (v: string) => void;
}

export function VisitorFilters({
  search,
  setSearch,
  filterPerson,
  setFilterPerson,
  filterReason,
  setFilterReason,
}: Props) {
  return (
    <div className="filters-container">
      {/* Search Box */}
      <input
        type="text"
        placeholder="Search visitor..."
        value={search}
        onChange={(e) => setSearch(e.target.value)}
        className="search-box"
      />

      {/* Person to meet */}
      <select
        value={filterPerson}
        onChange={(e) => setFilterPerson(e.target.value)}
        className="filter-dropdown"
      >
        <option value="">Person to Meet</option>
        <option value="Manager">Manager</option>
        <option value="HR">HR</option>
        <option value="Admin">Admin</option>
      </select>

      {/* Reason */}
      <select
        value={filterReason}
        onChange={(e) => setFilterReason(e.target.value)}
        className="filter-dropdown"
      >
        <option value="">Reason</option>
        <option value="Interview">Interview</option>
        <option value="Delivery">Delivery</option>
        <option value="Document">Document</option>
      </select>
    </div>
  );
}
