// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRearAura : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M256 23.545c-33.5 0-63.525 15.197-83.55 39.053L92.7 38.313l60.85 56.867c-2.134 5.82-3.785 11.872-4.905 18.105L18.498 132.592 148.635 151.9c1.118 6.238 2.768 12.293 4.902 18.118L92.7 226.873l78.898-24.025c1.62-2.674 3.35-5.246 5.203-7.702 2.154-2.85 4.502-5.53 7.02-8.027-11.435-15.14-18.21-34.01-18.21-54.503 0-50.03 40.357-90.39 90.39-90.39 50.03 0 90.39 40.36 90.39 90.39 0 20.494-6.774 39.36-18.208 54.5 2.518 2.497 4.868 5.177 7.02 8.03 1.855 2.455 3.585 5.028 5.204 7.703l78.895 24.023-60.837-56.857c2.133-5.824 3.784-11.88 4.902-18.116l130.137-19.308-130.147-19.307c-1.12-6.232-2.77-12.283-4.906-18.103l60.85-56.87-79.75 24.286C319.52 38.743 289.5 23.545 256 23.545zm.002 45.182c-23.1 0-42.257 23.548-45.89 54.412h36.544v18.686H209.85c1.698 19.243 9.403 35.878 20.408 46.133H219.94c-11.947 2.392-20.787 8.595-28.223 18.446-7.56 10.013-13.304 23.86-17.34 39.875-7.365 29.223-8.98 65.15-9.22 97.33h39.972l10.32 149.056h81.103l10.322-149.057h39.973c-.24-32.18-1.856-68.107-9.22-97.33-4.037-16.014-9.782-29.86-17.34-39.874-7.437-9.85-16.278-16.054-28.226-18.447h-10.316c11.005-10.256 18.71-26.89 20.408-46.134h-36.81V123.14h36.547c-3.633-30.865-22.79-54.413-45.888-54.413z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
