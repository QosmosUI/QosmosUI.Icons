// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoLogoSoundcloud : ComponentBase
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
		builder.AddAttribute(14, "d", "M5.8,278a2.11,2.11,0,0,0-2,2L0,308.64,3.74,336.8a2.12,2.12,0,0,0,2.05,2,2.14,2.14,0,0,0,2-2h0l4.44-28.17L7.83,280a2.14,2.14,0,0,0-2-2Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M26.85,262.32a2.13,2.13,0,0,0-4.26,0l-5,46.32,5,45.3a2.13,2.13,0,0,0,4.26,0l5.73-45.31-5.73-46.32Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M106.17,219.59a4,4,0,0,0-3.87,3.87l-4,85.22,4,55.08a3.88,3.88,0,0,0,7.75,0v0l4.53-55.08-4.53-85.22A4,4,0,0,0,106.17,219.59Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M65.12,249.21a3.09,3.09,0,0,0-3,3L57.6,308.66l4.51,54.63a3,3,0,0,0,6,0l5.13-54.63-5.13-56.48A3.1,3.1,0,0,0,65.12,249.21Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M147.88,367.6a4.83,4.83,0,0,0,4.75-4.74l3.93-54.15-3.93-113.46a4.75,4.75,0,0,0-9.5,0l-3.49,113.45,3.49,54.17A4.81,4.81,0,0,0,147.88,367.6Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M233.28,367.85a6.6,6.6,0,0,0,6.5-6.52v0l2.74-52.6-2.74-131a6.5,6.5,0,1,0-13,0l-2.45,131c0,.08,2.45,52.67,2.45,52.67A6.59,6.59,0,0,0,233.28,367.85Z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M190.26,367.65a5.67,5.67,0,0,0,5.62-5.64v0l3.34-53.33-3.34-114.28a5.63,5.63,0,1,0-11.25,0l-3,114.29,3,53.32a5.66,5.66,0,0,0,5.63,5.6Z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M85.56,367.15A3.53,3.53,0,0,0,89,363.74l4.83-55.09L89,256.25a3.44,3.44,0,0,0-6.88,0l-4.26,52.38,4.26,55.08A3.5,3.5,0,0,0,85.56,367.15Z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M44.84,364.13a2.67,2.67,0,0,0,2.57-2.52l5.43-53-5.42-55a2.57,2.57,0,0,0-5.14,0l-4.78,55,4.78,53a2.62,2.62,0,0,0,2.56,2.53Z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M211.69,192.53a6.1,6.1,0,0,0-6.07,6.09l-2.71,110.11,2.71,53a6.07,6.07,0,0,0,12.13,0v0l3-53-3-110.13a6.1,6.1,0,0,0-6.06-6.07Z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M127,367.71a4.41,4.41,0,0,0,4.31-4.3l4.23-54.71L131.26,204a4.32,4.32,0,0,0-8.63,0L118.89,308.7l3.75,54.73A4.38,4.38,0,0,0,127,367.71Z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M174.17,362.54v0l3.63-53.8-3.63-117.28a5.19,5.19,0,1,0-10.37,0l-3.23,117.28,3.23,53.83a5.18,5.18,0,0,0,10.36,0v0Z");
		builder.CloseElement();
		builder.OpenElement(37, "path");
		builder.AddAttribute(38, "d", "M449,241.1A62.42,62.42,0,0,0,424.67,246c-5-57.18-52.61-102-110.66-102a111.92,111.92,0,0,0-40.28,7.58c-4.75,1.85-6,3.76-6.06,7.46V360.4a7.66,7.66,0,0,0,6.8,7.5c.16,0,173.44.11,174.56.11,34.78,0,63-28.41,63-63.45s-28.2-63.46-63-63.46Z");
		builder.CloseElement();
		builder.OpenElement(39, "path");
		builder.AddAttribute(40, "d", "M254.79,158.87a7,7,0,0,0-6.94,7L245,308.75l2.85,51.87a6.94,6.94,0,1,0,13.87-.06v.06l3.09-51.87-3.09-142.93a7,7,0,0,0-6.93-6.95Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
