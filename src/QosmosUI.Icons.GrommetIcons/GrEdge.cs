// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GrommetIcons;

public class GrEdge : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "none";

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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "clip-path", "url(#a)");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M21.666 17.873c-.32.165-.65.308-.991.44a9.628 9.628 0 0 1-3.369.606c-4.437 0-8.3-3.05-8.3-6.97 0-1.102.638-2.06 1.54-2.556-4.018.166-5.042 4.35-5.042 6.795 0 6.927 6.386 7.632 7.762 7.632.737 0 1.86-.22 2.532-.43a.539.539 0 0 0 .12-.044 12.066 12.066 0 0 0 6.243-4.956c.21-.319-.154-.704-.495-.517Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M9.908 22.641a7.411 7.411 0 0 1-2.136-2.004 7.623 7.623 0 0 1-1.42-4.449 7.616 7.616 0 0 1 2.896-6.002 7.658 7.658 0 0 1 1.288-.804c.297-.143.792-.385 1.453-.374 1.1.011 1.937.573 2.41 1.211a3.02 3.02 0 0 1 .595 1.751c0-.022 2.29-7.466-7.508-7.466C3.391 4.504 0 8.414 0 11.849c0 2.17.506 3.91 1.134 5.253a12.065 12.065 0 0 0 7.21 6.343 11.88 11.88 0 0 0 3.667.573c1.32 0 2.598-.22 3.798-.617a7.14 7.14 0 0 1-2.136.33 7.2 7.2 0 0 1-3.765-1.09Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M14.279 13.964c-.077.099-.309.23-.309.528 0 .242.154.485.44.683 1.355.936 3.887.815 3.898.815 1.046 0 1.992-.297 2.84-.782.386-.22.738-.496 1.057-.793 1.101-1.046 1.773-2.522 1.795-4.163.022-2.103-.75-3.502-1.068-4.118C20.95 2.235 16.668 0 12 0 5.427 0 .088 5.286 0 11.838c.044-3.425 3.446-6.2 7.497-6.2.33 0 2.202.033 3.941.947 1.53.804 2.334 1.773 2.896 2.742.583 1.002.682 2.269.682 2.764 0 .496-.264 1.256-.737 1.873Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(21, "defs");
		builder.OpenElement(22, "linearGradient");
		builder.AddAttribute(23, "id", "b");
		builder.AddAttribute(24, "x1", "5.501");
		builder.AddAttribute(25, "x2", "22.225");
		builder.AddAttribute(26, "y1", "16.605");
		builder.AddAttribute(27, "y2", "16.605");
		builder.AddAttribute(28, "gradientUnits", "userSpaceOnUse");
		builder.OpenElement(29, "stop");
		builder.AddAttribute(30, "stop-color", "#0C59A4");
		builder.CloseElement();
		builder.OpenElement(31, "stop");
		builder.AddAttribute(32, "offset", "1");
		builder.AddAttribute(33, "stop-color", "#114A8B");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(34, "linearGradient");
		builder.AddAttribute(35, "id", "c");
		builder.AddAttribute(36, "x1", "14.318");
		builder.AddAttribute(37, "x2", "3.868");
		builder.AddAttribute(38, "y1", "9.347");
		builder.AddAttribute(39, "y2", "20.726");
		builder.AddAttribute(40, "gradientUnits", "userSpaceOnUse");
		builder.OpenElement(41, "stop");
		builder.AddAttribute(42, "stop-color", "#1B9DE2");
		builder.CloseElement();
		builder.OpenElement(43, "stop");
		builder.AddAttribute(44, "offset", ".162");
		builder.AddAttribute(45, "stop-color", "#1595DF");
		builder.CloseElement();
		builder.OpenElement(46, "stop");
		builder.AddAttribute(47, "offset", ".667");
		builder.AddAttribute(48, "stop-color", "#0680D7");
		builder.CloseElement();
		builder.OpenElement(49, "stop");
		builder.AddAttribute(50, "offset", "1");
		builder.AddAttribute(51, "stop-color", "#0078D4");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(52, "radialGradient");
		builder.AddAttribute(53, "id", "d");
		builder.AddAttribute(54, "cx", "0");
		builder.AddAttribute(55, "cy", "0");
		builder.AddAttribute(56, "r", "1");
		builder.AddAttribute(57, "gradientTransform", "rotate(92.128 -.93 3.333) scale(18.9898 40.4341)");
		builder.AddAttribute(58, "gradientUnits", "userSpaceOnUse");
		builder.OpenElement(59, "stop");
		builder.AddAttribute(60, "stop-color", "#35C1F1");
		builder.CloseElement();
		builder.OpenElement(61, "stop");
		builder.AddAttribute(62, "offset", ".111");
		builder.AddAttribute(63, "stop-color", "#34C1ED");
		builder.CloseElement();
		builder.OpenElement(64, "stop");
		builder.AddAttribute(65, "offset", ".232");
		builder.AddAttribute(66, "stop-color", "#2FC2DF");
		builder.CloseElement();
		builder.OpenElement(67, "stop");
		builder.AddAttribute(68, "offset", ".315");
		builder.AddAttribute(69, "stop-color", "#2BC3D2");
		builder.CloseElement();
		builder.OpenElement(70, "stop");
		builder.AddAttribute(71, "offset", ".673");
		builder.AddAttribute(72, "stop-color", "#36C752");
		builder.CloseElement();
		builder.OpenElement(73, "stop");
		builder.AddAttribute(74, "offset", "1");
		builder.AddAttribute(75, "stop-color", "#36C752");
		builder.CloseElement();
		builder.CloseElement();
		builder.OpenElement(76, "clipPath");
		builder.AddAttribute(77, "id", "a");
		builder.OpenElement(78, "path");
		builder.AddAttribute(79, "d", "M0 0h24v24H0z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
