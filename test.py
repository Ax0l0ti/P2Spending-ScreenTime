import json
import os
import random
import matplotlib.pyplot as plt
import sys


category = sys.argv[1]

if category == "Overall":
    category = None


historical_data = {
    "Week1": {"Transport": 10.4, "Groceries": 55, "Services": 15, "Restaurants": 14.8, "Utilities": 20, "Shopping": 0, "Health": 8.5, "General": 25, "Entertainment": 4},
    "Week2": {"Transport": 12, "Groceries": 62, "Services": 10, "Restaurants": 0, "Utilities": 20, "Shopping": 25, "Health": 8.5, "General": 18, "Entertainment": 4},
    "Week3": {"Transport": 8.4, "Groceries": 52, "Services": 9.5, "Restaurants": 12, "Utilities": 20, "Shopping": 0, "Health": 8.5, "General": 27, "Entertainment": 4},
    "Week4": {"Transport": 6.5, "Groceries": 68, "Services": 5.5, "Restaurants": 0, "Utilities": 20, "Shopping": 0, "Health": 8.5, "General": 21, "Entertainment": 4}
}


def generate_future_spending(historical_data, months=3):
    future_data = {}
    for month in range(1, months + 1):
        future_data[f"Month{month}"] = {}
        for week in historical_data:
            future_data[f"Month{month}"][week] = {}
            for category, amount in historical_data[week].items():
                fluctuation = random.uniform(-0.1, 0.1) * amount
                future_data[f"Month{month}"][week][category] = round(amount + fluctuation, 2)
    return future_data


def trend_analysis(spending_data, category=None):
    weekly_totals = {}

    # Iterate through each month and week
    for month, weeks in spending_data.items():
        for week, categories in weeks.items():
            week_identifier = f"{month}_{week}"
            if week_identifier not in weekly_totals:
                weekly_totals[week_identifier] = 0

            # If a category is specified, sum only that category
            if category:
                if category in categories:
                    weekly_totals[week_identifier] += categories[category]
            else:
                # Sum all categories for overall spending
                weekly_totals[week_identifier] += sum(categories.values())

    # Sorting the weeks to ensure the plot follows the chronological order
    sorted_weeks = sorted(weekly_totals.keys(), key=lambda x: (int(x[5:x.find('_')]), int(x[x.find('Week') + 4:])))
    sorted_totals = [weekly_totals[week] for week in sorted_weeks]

    # Plotting the data
    plt.figure(figsize=(10, 5))
    plt.plot([week.replace('_', ' ') for week in sorted_weeks], sorted_totals, marker='o')
    plt.title(f"Spending Trend Analysis - {'Overall' if category is None else category}")
    plt.xlabel("Time (Month_Week)")
    plt.ylabel("Spending ($)")
    plt.grid(True)
    plt.xticks(rotation=45)
    plt.tight_layout()
    output_directory = os.getcwd()

    # Saves the plot to the C# project's directory
    plot_path = os.path.join(output_directory, 'plot5.jpg')
    try:
        plt.savefig(plot_path, format='jpg')
    except Exception as e:
        print("Error saving plot:", e)

    # plt.show()


data = generate_future_spending(historical_data, 3)

trend_analysis(data, category)
