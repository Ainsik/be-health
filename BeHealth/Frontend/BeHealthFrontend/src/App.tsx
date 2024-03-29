import "./App.css";
import Footer from "./components/layout/Footer/Footer";
import { Routes, Route } from "react-router-dom";
import ArrangeVisit from "./pages/ArrangeVisit";
import { Navbar } from "./components/layout/Navbar";
import { Sidebar } from "./components/layout/Sidebar";
import CategoriesSearch from "./pages/CategoriesSearch";
import { Visits } from "./pages/doctor/Visits";
import { Calendar } from "./pages/doctor/Calendar";
import { Login } from "./pages/auth/Login";
import { Register } from "./pages/auth/register/Register";
import { BeHealthContext } from "./Context";
import { useState } from "react";
import { User } from "./utils/auth";
import { Referrals } from "./pages/patient/Referrals";
import { Recipes } from "./pages/patient/Recipes";
import { DoctorProfile } from "./pages/DoctorProfileForUser";
import OfficeHours from "./pages/doctor/OfficeHours";
import { Profile } from "./pages/doctor/profile/Profile";
import { VisitsPatient } from "./pages/patient/VisitsPatient";
import { MainPage } from "./pages/MainPage";

function App() {
	const [openSidebar, setOpenSidebar] = useState(false);
	const toggleSidebar = () => setOpenSidebar((prev) => !prev);

	const [currentUser, setCurrentUser] = useState<User>();
	const [token, setToken] = useState("");
	const [urlRedirect, setUrlRedirect] = useState("");

	return (
		<>
			<BeHealthContext.Provider
				value={{
					user: currentUser,
					setUser: setCurrentUser,
					token: token,
					setToken: setToken,
					urlRedirect: urlRedirect,
					setUrlRedirect: setUrlRedirect,
				}}>
				<Navbar />
				<div className="container">
					<Sidebar isOpen={openSidebar} toggle={toggleSidebar} />
					<Routes>
						<Route path="/categories-search" element={<CategoriesSearch />} />
						<Route path="/visits" element={<Visits />} />
						<Route path="/calendar" element={<Calendar />} />
						<Route path="/login" element={<Login />} />
						<Route path="/register" element={<Register />} />
						<Route path="/referrals" element={<Referrals />} />
						<Route path="/recipes" element={<Recipes />} />
						<Route
							path="/doctor/profile/:doctorId"
							element={<DoctorProfile />}
						/>
						<Route path="/officehours" element={<OfficeHours />} />
						<Route
							path="/doctor/profile/:doctorId/arrangevisit"
							element={<ArrangeVisit />}
						/>
						<Route path="/profile" element={<Profile />} />
						<Route path="/visitsuser" element={<VisitsPatient />} />
						<Route path="/" element={<MainPage />} />
					</Routes>
				</div>
				<Footer />
			</BeHealthContext.Provider>
		</>
	);
}

export default App;
