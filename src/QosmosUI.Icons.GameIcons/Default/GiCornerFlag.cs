// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCornerFlag : ComponentBase
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
		builder.AddAttribute(14, "d", "M247 32v298.582l-41.893 22.178c-3.534 10.965-9.343 20.92-16.877 29.303l67.77-35.88 105.512 55.86c-65.754 32.576-140.177 33.31-206.332 2.242C146.677 407.328 137.53 409 128 409c-7.938 0-15.606-1.17-22.863-3.313L18 451.817v20.365l113.213-59.936c78.502 43.595 171.072 43.595 249.574 0L494 472.182v-20.364L265 330.582V143.756c25.495-1.29 37.302-7.34 55 .244 29.395 23.17 64 48 96 48l-16-32c-48 0-53.708-90.33-80-112-19.185-11.34-29.794-15.214-55-15.88V32h-18zM116.963 265.975c-15.102 2.65-28.325 10.627-37.65 21.957L80 288l5.658 25.99-20.61 12.035c-.02.658-.048 1.313-.048 1.975 0 9.597 2.134 18.675 5.94 26.8l1.53-2.8 26.145 4.893 3.426 26.377-2.284 1.085C108.244 388.6 117.83 391 128 391c3.24 0 6.42-.244 9.525-.71l-6.257-6.618L144 360.316l26.146 4.89 1.124 8.64c10.107-9.54 17.04-22.395 19.09-36.87l-7.628 3.883-18.808-18.81L176 298.35l8.31 1.316c-6.132-12.207-16.102-22.12-28.357-28.17l.094 1.15-24.547 10.25-14.537-16.92zM128 304l18.81 18.81-12.078 23.7-26.27-4.16-4.163-26.274L128 304z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
