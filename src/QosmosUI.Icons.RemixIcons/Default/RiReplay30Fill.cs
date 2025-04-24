// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiReplay30Fill : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M22 12C22 6.47715 17.5228 2 12 2 8.9841 2 6.28002 3.33509 4.44656 5.44648L2 3V9H6.75V10H9.37481C9.71999 10 9.99981 10.2798 9.99981 10.625 9.99981 10.9702 9.71999 11.25 9.37481 11.25H7.5V12.75H9.37481C9.71999 12.75 9.99981 13.0298 9.99981 13.375 9.99981 13.7202 9.71999 14 9.37481 14H6.75V15.5H9.37481C10.5484 15.5 11.4998 14.5486 11.4998 13.375 11.4998 12.8506 11.3099 12.3706 10.9951 12 11.3099 11.6294 11.4998 11.1494 11.4998 10.625 11.4998 9.4514 10.5484 8.5 9.37481 8.5H7.49988L5.86492 6.86543C7.33243 5.11383 9.53614 4 12 4 16.4183 4 20 7.58172 20 12 20 16.4183 16.4183 20 12 20 7.58172 20 4 16.4183 4 12H2C2 17.5228 6.47715 22 12 22 17.5228 22 22 17.5228 22 12ZM12.5 10.75C12.5 9.36929 13.6193 8.25 15 8.25 16.3807 8.25 17.5 9.36929 17.5 10.75V13.25C17.5 14.6307 16.3807 15.75 15 15.75 13.6193 15.75 12.5 14.6307 12.5 13.25V10.75ZM15 9.75C14.4477 9.75 14 10.1977 14 10.75V13.25C14 13.8023 14.4477 14.25 15 14.25 15.5523 14.25 16 13.8023 16 13.25V10.75C16 10.1977 15.5523 9.75 15 9.75Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
