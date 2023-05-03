import { PrimaryButton } from "../components/ui/PrimaryButton"
import "./MainPage.css"
import DoctorImage from "../assets/images/doctorWithCircleBackgound.png"
import SampleDoctor1 from "../assets/images/Specialist 1.png"
import SampleDoctor2 from "../assets/images/Specialist 2.png"
import SampleDoctor3 from "../assets/images/Specialist 3.png"
import Medicover from "../assets/images/medicover.png"
import Scanmed from "../assets/images/scanmed.png"
import Zdziecko from "../assets/images/zdziecko.png"
import BenefitsDoctor from "../assets/images/benefitsDoctor.png"
import { BsCheckLg } from "react-icons/bs"

const PartnersBadge = () => {
  return (
    <div className="partners--badge">
      <div className="partners--badge-color"></div>
      <img src={Medicover} alt="" />
      <img src={Scanmed} alt="" />
      <img src={Zdziecko} alt="" />
    </div>
  )
}

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
    <>
      <section id="about--section" className="split">
        <div className="section--left">
          <h1 className="section--title">Znajdź lekarza<br />& zarezerwuj online</h1>
          <p className="section--text">Szybki i łatwy dostęp do opieki zdrowotnej na wyciągnięcie ręki</p>
          <PrimaryButton style={{ marginBlockStart: 40 }}><p style={{ color: "white", marginInline: 70, marginBlock: 5 }}>Zarezerwuj wizytę</p></PrimaryButton>
          <PartnersBadge />
        </div>
        <div className="section--right">
          <img id="doctor--image" src={DoctorImage} alt="Male doctor looks at camera and smiles" />
          <DoctorsBadge />
        </div>
      </section>
    </>
  )
}

const BenefitsBadge = () => {
  return (
    <div className="benefits--badge">
      <h3>Zalety</h3>
      <div className="benefits--badge-item">
        <div className="text">
          <h4 className="benefit--item-title">Współpracujemy tylko z najlepszymi</h4>
          <p className="benefit--item-text">Nasi lekarze są regularnie kontrolowani pod kątem wiedzy i umiejętności, a także stale podnoszą swoje kwalifikacje.</p>
        </div>
        <p className="benefit--number">01</p>
      </div>
      <div className="benefits--badge-item">
        <div className="text">
          <h4 className="benefit--item-title">Pacjenci otrzymują usługę bezpłatnie</h4>
          <p className="benefit--item-text">Pacjenci mogą korzystać z naszych usług bez dodatkowych kosztów</p>
        </div>
        <p className="benefit--number">02</p>
      </div>
    </div>
  )
}

const Benefits = () => {
  return (
    <section id="benefits--section" className="split">
      <div className="section--left">
        <img src={BenefitsDoctor} />
        <BenefitsBadge />
      </div>
      <div className="section--right">
        <p className="benefits--green-badge">Dlaczego my</p>
        <h1 className="section--title">Jesteśmy <span className="purple">liderami</span><br /> na rynku ochrony <br /> zdrowia</h1>
        <ul>
          <li><BsCheckLg />Przyjęcie w dogodnym czasie</li>
          <li><BsCheckLg />Konto osobowe</li>
          <li><BsCheckLg />Ubezpieczenie dla dzieci i dorosłych</li>
          <li><BsCheckLg />Wysoko wykwalifikowani specjaliści</li>
        </ul>
        <PrimaryButton style={{marginBlockStart: 30}}>Dowiedz się więcej</PrimaryButton>
      </div>
    </section>
  )
}

export const MainPage = () => {
  return (
    <main className="main--page">
      <About />
      <Benefits />
    </main>
  )
}
