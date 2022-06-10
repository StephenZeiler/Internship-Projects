import { render } from "@testing-library/react"
import styled from 'styled-components';

type weatherData = {
    Date: String,
    Location: String,
    Times: Number,
    Temp: Number,
    WindDir: String,
    ForecastDesc: String,
}

function Hourly(props: weatherData) {
    // TODO: 
    // Date
    // Location
    // Times
    // Hourly weather
}

function Daily(props: weatherData) {
    // TODO:
    // Date
    // Location
    // Weather
    // Wind Direction
}

function Evening(props: weatherData) {
    // TODO:
    // Date
    // Location
    // Weather
    // Detailed Forecast
    // Wind Direction
}

function WeatherData(props: weatherData) {
}

type layoutProps = {
    gap: number,
}

const Row = styled.div<layoutProps>`
     display: flex;
     flex-direction: row;
     gap: ${(layoutProps) => layoutProps.gap}px;
    `;
const Column = styled.div<layoutProps>`
    display: flex:
    flex-direction: column;
    gap: ${(layoutProps) => layoutProps.gap}px;
    `
render(<div>
    <h1>
        Location: XXXX, XX
    </h1>
    <Row gap={300}>
        <Row gap={300}>
            <Row gap={300}>
                Test: Evening
            </Row>
            Test: daily
        </Row>
        Test: hourly
    </Row>

</div>);