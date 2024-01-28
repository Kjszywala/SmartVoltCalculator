document.addEventListener('alpine:init', () => {
    Alpine.data('calculator', () => ({
        monthlyElectricityUsage: 168,
        priceKWH: 28.6,
        sum: this.monthlyElectricityUsage * (this.priceKWH / 100),
        chart: {
            height: 400,
            width: "100%",
            type: "donut",
        },
        async init() {
            console.log('Init in calculator');
        }
    }))
})
