// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiDirectionSign : ComponentBase
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
		builder.AddAttribute(14, "d", "M66.26 62.5c-4.533 0-9.11.862-11.564 1.906-.914.39-1.142.617-1.377.797v32.26l26.488.287-.47-32.488c-.237-.183-.513-.445-1.47-.85C75.382 63.36 70.795 62.5 66.26 62.5zM365.22 78.293c-.528.005-1.08.022-1.65.05-2.287.117-4.886.428-7.47.968-5.167 1.08-10.42 3.023-13.677 4.973-2.754 1.65-3.064 2.87-3.095 2.225l.143 20.05 29.85.323V78.585c-.124-.03-.017-.013-.16-.04-.998-.18-2.358-.267-3.94-.25zM19.413 115.1l.56 54.732 11.036 8.027-4.257 66.695 132.46 8.416-133.66 6.99-3.5 44.987 361.22-1.93 48.19-36.52.257-12.01 60.867-41.66-39.547-40.106-56.44-6.484 39.544-5.52-58.74-35.747zM369.32 321.092l-27.723.148 1.63 167.76h26.092V370.074l-9.272-4.303 9.27-5.23zm-286.428 1.53l-29.573.16V489h31.867z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
