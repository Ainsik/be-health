import { PrimaryButton } from "../components/ui/PrimaryButton"
import "./MainPage.css"
import DoctorImage from "../assets/images/doctorWithCircleBackgound.png"
import SampleDoctor1 from "../assets/images/Specialist 1.png"
import SampleDoctor2 from "../assets/images/Specialist 2.png"
import SampleDoctor3 from "../assets/images/Specialist 3.png"

const DoctorsBadge = () => {
  return (
    <div className="doctors--badge">
      <div className="doctor-images">
        <img src={SampleDoctor1} alt="" />
        <img src={SampleDoctor2} alt="" />
        <img src={SampleDoctor3} alt="" />
        <p><b>20+</b><br />Specialists</p>
      </div>
    </div>
  )
}

const About = () => {
  return (
    <section id="about--section" className="split">
      <div className="section--left">
        <h1 className="section--title">Znajdź lekarza<br />& zarezerwuj online</h1>
        <p className="section--text">Szybki i łatwy dostęp do opieki zdrowotnej na wyciągnięcie ręki</p>
        <PrimaryButton style={{ marginBlockStart: 40 }}><p style={{ color: "white", marginInline: 70, marginBlock: 5 }}>Zarezerwuj wizytę</p></PrimaryButton>
      </div>
      <div className="section--right">
        <img id="doctor--image" src={DoctorImage} alt="Male doctor looks at camera and smiles" />
        <DoctorsBadge />
      </div>
    </section>
  )
}

export const MainPage = () => {
  return (
    <main className="main--page">
      <About />
    </main>
  )
}
