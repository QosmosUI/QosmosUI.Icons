// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiPendulumSwing : ComponentBase
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
		builder.AddAttribute(14, "d", "M160.113 18l-20.398 253.85a57.09 57.09 0 0 1 5.27-.254c4.362 0 8.606.51 12.69 1.447L178.17 18h-18.057zM254 18v261.723a56.894 56.894 0 0 1 9-.723c3.06 0 6.067.247 9 .717V18h-18zm96 0v261.717a56.86 56.86 0 0 1 18 0V18h-18zm96 0v261.717a56.86 56.86 0 0 1 9-.717c3.062 0 6.066.253 9 .723V18h-18zM46.727 225.266c4.836 26.24 14.8 45.795 33.556 68.322-17.71-3.873-38.847-20.713-53.068-37.97 6.053 23.69 30.466 50.84 48.613 68.017-14.17-1.282-41.672-13.72-56.185-23.375 6.067 14.415 37.752 46.36 56.537 51.074-23.762 3.01-44.836-8.756-51.973-11.7 6.418 13.096 22.893 28.957 88.756 36.055-15.053-10.283-24.977-27.574-24.977-47.094 0-21.774 12.348-40.77 30.39-50.364-26.667-9.646-51.795-25.765-71.65-52.966zm98.26 64.33c-21.646 0-39 17.354-39 39 0 21.645 17.354 39 39 39 21.645 0 39-17.355 39-39 0-21.646-17.355-39-39-39zM263 297c-21.646 0-39 17.354-39 39s17.354 39 39 39 39-17.354 39-39-17.354-39-39-39zm96 0c-21.646 0-39 17.354-39 39s17.354 39 39 39 39-17.354 39-39-17.354-39-39-39zm96 0c-21.646 0-39 17.354-39 39s17.354 39 39 39 39-17.354 39-39-17.354-39-39-39z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
