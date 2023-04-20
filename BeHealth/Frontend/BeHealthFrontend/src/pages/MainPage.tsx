import { PrimaryButton } from "../components/ui/PrimaryButton"
import "./MainPage.css"
import DoctorImage from "../assets/images/doctorWithCircleBackgound.png"

export const MainPage = () => {
  return (
    <main className="main--page">
        <section id="about--section" className="split">
            <div className="left">
                <h1 className="section--title">Znajdź lekarza<br/>& zarezerwuj online</h1>
                <p className="section--text" style={{marginBlockStart: 10}}>Szybki i łatwy dostęp do opieki zdrowotnej na wyciągnięcie ręki</p>
                <PrimaryButton style={{marginBlockStart: 40}}><p style={{color: "white", marginInline: 70, marginBlock: 5}}>Zarezerwuj wizytę</p></PrimaryButton>
            </div>
            <div className="right">
                <img src={DoctorImage} alt="Male doctor looks at camera and smiles" />
            </div>
        </section>
    </main>
  )
}
