// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiEnergyTank : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 25.908l-66.275 44.184h132.55zM131.727 88.092L105 114.818v168.547l26.727 26.727h61.71L167 257.217V155.365l32-32V88.092zm181.273 0v35.273l32 32v101.852l-26.438 52.875h61.711L407 283.365V114.818l-26.727-26.726zm-176 240v30h50.184l20-30zm91.816 0l-20 30h94.368l-20-30zm76 0l20 30H375v-30zm-167.816 48v30h50.184l20-30zm91.816 0l-20 30h95.145l-18.316-30zm77.916 0l18.319 30H375v-30zm-267.355 48l-12.4 62H71v-62zm49.623 0v62h138.1c-7.463-7.437-12.1-17.707-12.1-29 0-13.49 6.618-25.515 16.762-33zm191.238 0c10.144 7.485 16.762 19.51 16.762 33 0 11.293-4.637 21.563-12.1 29H407v-62zm144.762 0v62h60.023l-12.4-62zm-169 10c-12.81 0-23 10.19-23 23s10.19 23 23 23 23-10.19 23-23-10.19-23-23-23z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
