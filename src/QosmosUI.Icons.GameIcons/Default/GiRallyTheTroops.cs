// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiRallyTheTroops : ComponentBase
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
		builder.AddAttribute(14, "d", "M462.9 19.12c-9.6 0-17.2 7.59-17.2 17.19 0 9.61 7.6 17.19 17.2 17.19s17.2-7.58 17.2-17.19c0-9.6-7.6-17.19-17.2-17.19zm-80.3 21.82c-160.3.8-218.1 217.46-362.93 96.26 3.25 36.8 88.43 78.4 88.43 78.4-26.03 20-34.78 24.7-71.99 25.5 104.09 86.7 338.69-99.8 408.39 40.1l-2.3-38.4-45.4-46.5 42.7.6-.6-10.2-50.7-32.2 48.4-7.2-.7-11.1-50-27.3 47.9-8.8-.6-10.69L381 66.66l50.5-5.85-.8-13.9c-17.1-4.2-33-6.05-48.1-5.97zm70.8 29.97l20.2 423.99 18.7-.9-20.2-423c-6.3 1.54-12.7 1.5-18.7-.1zM360 292.9l-43.6 70 21.3 25L322 493h18.9l15.2-102.3 28-20.2c-8.1-25.9-16.1-51.8-24.1-77.6zm-156.7 17.9l-28.8 69.8 20.5 20.2 2.2 92.2h18.7l-2.2-93 19.6-19.9-30-69.3zm-158.16 5l-16.4 61.9 17.65 13.2L61.24 493h18.87L64.89 388.3l13.22-17.6-32.93-54.9zm85.96 7.4l-28.2 57.5 15.1 17-6.7 95.3H130l6.8-95.3 15.9-14.2-21.6-60.3zM268 355.5l-19.5 68.4 19.4 15.2 5.8 53.9h18.9l-5.9-54.3 16.8-21.6c-11.9-20.5-23.7-41-35.5-61.6zm143.6.1l-18.9 68.6 20.3 15.5 6.2 53.3H438l-6.4-55.2 16-20.9z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
