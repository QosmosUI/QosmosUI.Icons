// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiDunceCap : ComponentBase
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
		builder.AddAttribute(14, "d", "M330.445 26.006l-126.79 211.61c24.586 20.357 46.073 33.117 68.584 38.63 22.632 5.543 47.123 4.26 78.421-4.044zM189.119 249.81C163.03 273.734 146 311.377 146 354.309c0 73.606 50.048 131.685 110 131.685s110-58.08 110-131.685c0-23.104-4.932-44.677-13.553-63.406-32.014 8.151-59.115 9.557-84.609 3.313-27.08-6.632-51.752-21.655-78.72-44.405zm47.507 88.622l5.851 17.553-49.345 16.448-5.85-17.552zm38.748 0l49.345 16.449-5.851 17.552-49.345-16.448zM256 411.977c19.532 0 38.348 9.842 55.886 27.38l-13.083 13.084c-15.358-15.358-29.438-21.964-42.803-21.964-13.365 0-27.445 6.606-42.803 21.964l-13.083-13.083c17.538-17.539 36.354-27.381 55.886-27.381z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
