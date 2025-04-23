// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWeightLiftingDown : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h512v512H0z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M0 0h512v512H0z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M0 0h512v512H0z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M0 0h512v512H0z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M256 193c-20.835 0-39 20.24-39 47s18.165 47 39 47 39-20.24 39-47-18.165-47-39-47zm-56.154 58.045c-31.257 8.56-47.236 34.018-61.975 61.45-17.314 32.592-28.125 71.052-36.09 102.505H89v-55H71v55H55v-39H37v39H20v18h17v39h18v-39h16v55h18v-55h84.592c5.427 13 11.908 26 18.408 39l-48 6v15h72.79l-12.35-60h103.12l-12.35 60H368v-15l-48-6c6.5-13 12.98-26 18.408-39H423v55h18v-55h16v39h18v-39h17v-18h-17v-39h-18v39h-16v-55h-18v55h-12.78c-7.967-31.463-18.818-70.017-36.857-102.727-15.017-27.23-29.637-51.526-61.316-60.543C307.244 281.506 284.524 305 256 305c-28.743 0-51.593-23.856-56.154-53.955zm-3.608 48.385l10.04 50.24C176 360 160 360 160 376c0 13 2.64 26 6.85 39h-32.032c7.596-28.945 17.637-61.754 31.31-87.494 9.008-14.526 17.53-18.784 30.11-28.076zm119.3 1.35c11.32 8.253 20.97 10.93 29.804 26.947 14.136 25.632 24.233 58.35 31.836 87.273H345.15c4.21-13 6.85-26 6.85-39 0-16-16-16-46.28-26.33l9.817-48.89zM256 376c22.95 0 60 16 60 16l-4.734 23H200.734L196 392s37.05-16 60-16z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
