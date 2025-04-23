// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiStripedSun : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 32a224 224 0 0 0-161.393 69.035h323.045A224 224 0 0 0 256 32zM79.148 118.965a224 224 0 0 0-16.976 25.16H449.74a224 224 0 0 0-16.699-25.16H79.148zm-27.222 45.16A224 224 0 0 0 43.3 186.25h425.271a224 224 0 0 0-8.586-22.125H51.926zM36.783 210.25a224 224 0 0 0-3.02 19.125h444.368a224 224 0 0 0-3.113-19.125H36.783zm-4.752 45.125A224 224 0 0 0 32 256a224 224 0 0 0 .64 16.5h446.534A224 224 0 0 0 480 256a224 224 0 0 0-.021-.625H32.03zm4.67 45.125a224 224 0 0 0 3.395 15.125h431.578a224 224 0 0 0 3.861-15.125H36.701zm14.307 45.125a224 224 0 0 0 6.017 13.125H454.82a224 224 0 0 0 6.342-13.125H51.008zm26.316 45.125a224 224 0 0 0 9.04 11.125H425.86a224 224 0 0 0 8.727-11.125H77.324zm45.62 45.125A224 224 0 0 0 136.247 445h239.89a224 224 0 0 0 12.936-9.125h-266.13z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
