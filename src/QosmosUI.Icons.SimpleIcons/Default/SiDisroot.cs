// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDisroot : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M3.976 2.856C2.321 3.296.603 4.491.122 5.536c-.144.315-.164.885-.04 1.133.178.35.343.384 1.387.24.817-.11 1.085-.117 1.985-.055 1.106.076 1.594.213 1.882.522.172.179 3.75 9.033 3.813 9.418.11.694-.234 1.312-1.189 2.143-.797.687-.927.907-.824 1.381.151.666.508.982 1.113.982.508 0 2.095-.268 3.297-.55 3.476-.817 6.437-1.923 8.504-3.173 1.944-1.168 3.25-2.555 3.765-3.984.15-.433.178-.618.185-1.326 0-.975-.11-1.38-.536-1.958-.858-1.16-1.8-2.005-3.338-2.988-2.96-1.902-3.778-2.294-6.67-3.215-2.521-.803-5.358-1.318-7.728-1.394-1.017-.027-1.147-.02-1.752.144zm9.411 6.526c1.477.563 2.823 1.47 4.554 3.07.838.777 1.024 1.072 1.058 1.732.076 1.23-.597 2.033-2.088 2.507-.708.22-2.191.536-2.253.474-.02-.014 0-.13.041-.254.048-.13.062-.447.048-.749-.027-.433-.096-.68-.364-1.319-.179-.433-.708-1.91-1.175-3.283l-.851-2.5.22.047c.123.028.487.151.81.275z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
