// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHive : ComponentBase
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
		builder.AddAttribute(14, "d", "M196 16s-60 20.07-60 45h-15c-33.24 0-60 20.07-60 45 0 11.496 5.61 22.062 15 30-33.24 0-60 30.915-60 60s26.76 45 60 45h30.47C111.154 160.246 153.625 93.326 211 69.906V16h-15zm105 0v53.906c57.372 23.42 99.844 90.34 104.53 171.094H436c33.24 0 60-15.915 60-45s-26.76-60-60-60c9.392-7.938 15-18.504 15-30 0-24.93-26.76-45-60-45h-15c0-24.93-60-45-60-45h-15zm-44.156 105a30 30 0 0 0-30.875 29.97 30 30 0 0 0 60 0A30 30 0 0 0 256.843 121zm.5 90.063a45 45 0 0 0-46.313 44.968 45 45 0 0 0 90 0 45 45 0 0 0-43.686-44.967zM151.844 226a30 30 0 0 0-30.875 29.97 30 30 0 0 0 60 0A30 30 0 0 0 151.843 226zm210 0a30 30 0 0 0-30.875 29.97 30 30 0 0 0 60 0A30 30 0 0 0 361.843 226zM76 271c-33.24 0-60 15.915-60 45s26.76 60 60 60c-9.39 7.938-15 18.504-15 30 0 24.93 26.76 45 60 45h15c0 24.93 60 45 60 45h15v-53.906c-57.372-23.42-99.844-90.34-104.53-171.094H76zm329.53 0c-4.685 80.754-47.156 147.674-104.53 171.094V496h15s60-20.07 60-45h15c33.24 0 60-20.07 60-45 0-11.496-5.608-22.062-15-30 33.24 0 60-30.915 60-60s-26.76-45-60-45h-30.47zm-148.686 60a30 30 0 0 0-30.875 29.97 30 30 0 0 0 60 0A30 30 0 0 0 256.843 331z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
