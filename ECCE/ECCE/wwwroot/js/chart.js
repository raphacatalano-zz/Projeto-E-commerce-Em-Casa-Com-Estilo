function Pie() {
        google.charts.load('current', {packages: ['corechart'] })
    google.charts.setOnLoadCallback(drawChart)

    function drawChart() {
        const container = document.querySelector('#Pie')
        const data = new google.visualization.arrayToDataTable([
            ['Character', 'Ki'],
            ['Goku', 10000],
            ['Vegeta', 9000],
            ['Gohan', 8000],
            ['Freeza', 5000],
            ['Piccolo', 2000]
        ])
        const options = {
            title: 'Dragon Ball Z - Characters Ki',
            height: 400,
            width: 720
        }

        //const chart = new google.visualization.ColumnChart(container)
        // const chart = new google.visualization.BarChart(container)
        // const chart = new google.visualization.LineChart(container)
        const chart = new google.visualization.PieChart(container)
        chart.draw(data, options)
    }
}