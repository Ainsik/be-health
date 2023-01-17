import "./App.css";
import Footer from "./components/layout/Footer/Footer";
import { Routes, Route } from "react-router-dom";
import ArangeVisit from "./pages/ArangeVisit";
import { Navbar } from "./components/layout/Navbar";
import { Sidebar } from "./components/layout/Sidebar";
import { useState } from "react";

function App() {
	const [openSidebar, setOpenSidebar] = useState(true)
	const toggleSidebar = () => setOpenSidebar(prev => !prev);

	return (
		<>
			<Navbar />
			<div className="container">
				<Sidebar isOpen={openSidebar} toggle={toggleSidebar} />
				<Routes>
					<Route path="/arange-visit" element={<ArangeVisit />} />
				</Routes>
			</div>
			<Footer />
		</>
	);
}

export default App;
